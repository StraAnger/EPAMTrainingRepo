using Serilog;

namespace Task8.PL.Console
{
        public static class SerilogHelper
        {
            public static void InitializeLogger(bool fileLogs = false, string fileName = "logs/log.txt")
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
        }
}