using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Task_4_1_1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {



            string pathToOriginalData = ".";

            if (args.Length != 0 && Directory.Exists(args[0])) pathToOriginalData = args[0];

            string pathToCopyDirectories = $"{pathToOriginalData}\\_temp_copy_of_changed_files$";

            Console.WriteLine($"Starting monitor *.txt files in folder \"{pathToOriginalData}\"");

            InitializeLogger(true, $"{pathToOriginalData}\\Logs\\Changes.log");

            try
            {

                Directory.CreateDirectory(pathToCopyDirectories);
                DirectoryInfo dir = new DirectoryInfo(pathToCopyDirectories);
                dir.Attributes |= FileAttributes.Hidden;


                using var watcher = new FileSystemWatcher(pathToOriginalData);

                watcher.NotifyFilter = NotifyFilters.Attributes
                                     | NotifyFilters.CreationTime
                                     | NotifyFilters.DirectoryName
                                     | NotifyFilters.FileName
                                     | NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Security
                                     | NotifyFilters.Size;


                watcher.Changed += OnChanged;
                watcher.Created += OnCreated;
                watcher.Deleted += OnDeleted;
                watcher.Renamed += OnRenamed;
                watcher.Error += OnError;

                watcher.Filter = "*.txt";
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;


                Console.WriteLine("Press Enter key to stop monitoring");
                Console.ReadLine();

                char keyInputChar1;
                int keyInputInt1;
                int counter = 0;

                do
                {
                    Console.WriteLine($"Enter \"R\" to restore file structure or any other to exit and delete recovery data on disk: ");

                    if (char.TryParse(Console.ReadLine(), out keyInputChar1))

                        if (keyInputChar1 == 'R' || keyInputChar1 == 'r' && (ListDataBackup(pathToOriginalData, pathToCopyDirectories).Count > 0))
                        {
                            foreach (string directory in ListDataBackup(pathToOriginalData, pathToCopyDirectories))
                            {

                                Console.WriteLine($"{counter}   :   {directory}");
                                ++counter;
                            }

                            Console.WriteLine($"Enter the number of copy to restore: ");

                            if (int.TryParse(Console.ReadLine(), out keyInputInt1))
                            {
                                if (keyInputInt1 < 0 || keyInputInt1 > ListDataBackup(pathToOriginalData, pathToCopyDirectories).Count)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }

                                RestoreDataBackup($"{pathToCopyDirectories}\\{ListDataBackup(pathToOriginalData, pathToCopyDirectories).ElementAt(keyInputInt1)}", ListDataBackup(pathToOriginalData, pathToCopyDirectories).ElementAt(keyInputInt1));

                            }
                        }
                    counter = 0;
                }
                while (keyInputChar1 == 'R' || keyInputChar1 == 'r' && (ListDataBackup(pathToOriginalData, pathToCopyDirectories).Count > 0));

                if (Directory.Exists(pathToCopyDirectories))
                    Directory.Delete(pathToCopyDirectories, true);

            }
            catch (Exception ex)
            {
                Log.Debug($"{ex}");
            }

            finally
            {
                if (Directory.Exists(pathToCopyDirectories))
                    Directory.Delete(pathToCopyDirectories, true);
            }
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            Log.Debug($"Changed: {e.FullPath}");

            var path = $".\\_temp_copy_of_changed_files$\\{DateTime.Now.ToString("MM'.'dd'.'yyyy'.'HH'.'mm'.'ss")}_copy";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory($"{path}\\{Path.GetDirectoryName(e.FullPath)}");

            File.Copy(e.FullPath, $"{path}\\{e.FullPath}.copy", true);

        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"Created: {e.FullPath}");

            var path = $".\\_temp_copy_of_changed_files$\\{DateTime.Now.ToString("MM'.'dd'.'yyyy'.'HH'.'mm'.'ss")}_copy";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory($"{path}\\{Path.GetDirectoryName(e.FullPath)}");

            File.Copy(e.FullPath, $"{path}\\{e.FullPath}.copy", true);

        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"Deleted: {e.FullPath}");

        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Log.Debug($"Renamed: ");
            Log.Debug($"    Old: {e.OldFullPath}");
            Log.Debug($"    New: {e.FullPath}");

            var path = $".\\_temp_copy_of_changed_files$\\{DateTime.Now.ToString("MM'.'dd'.'yyyy'.'HH'.'mm'.'ss")}_copy";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory($"{path}\\{Path.GetDirectoryName(e.FullPath)}");

            File.Copy(e.FullPath, $"{path}\\{e.FullPath}.copy", true);


        }

        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Log.Debug($"Message: {ex.Message}");
                Log.Debug("Stacktrace:");
                Log.Debug(ex.StackTrace);
                PrintException(ex.InnerException);
            }
        }


        private static void InitializeLogger(bool fileLogs = false, string fileName = "logs/myapp.text")
        {
            if (fileLogs)
                Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            // .WriteTo.Console()
                            .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                            .CreateLogger();
            else
                Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .CreateLogger();
        }


        private static List<string> ListDataBackup(string pathToOriginalData, string pathToCopyDirectories)
        {
            var DirList = new List<string>();

            foreach (var directory in System.IO.Directory.GetDirectories(pathToCopyDirectories))
            {
                var dirName = new DirectoryInfo(directory).Name;
                if (dirName != "Logs") DirList.Add(dirName);
            }


            return DirList;

        }

        private static void RestoreDataBackup(string pathToBackupedData, string directoryName)
        {
            var restoredFiles = Directory.GetFiles(pathToBackupedData, "*", SearchOption.AllDirectories);

            foreach (string file in restoredFiles)
            {
                File.Move(Path.GetFullPath(file), Path.GetFullPath(file).Replace(".copy", "").Replace($"\\_temp_copy_of_changed_files$\\{directoryName}", ""), true);
            }

        }

    }

}
