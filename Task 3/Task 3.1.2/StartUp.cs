using System;
using System.Collections.Generic;
using System.Linq;

// К вам пришёл редактор модного журнала. Ему очень нужна программа, которую он описал ниже.
// Задан английский текст. Ваша задача понять, какие слова автор «любит» больше всего и 
// подловить его на однообразности речи. Или, наоборот, похвалить за разнообразие.
// Для каждого слова в тексте указать, сколько раз оно встречается.
// Подумайте, имеет ли значение регистр, какие разделители могут использоваться в тексте. 
// Попробуйте использовать свои наработки из Task 1.2. «String, not Sting».
// Ввод и вывод также придумайте сами. В рамках консоли постарайтесь создать приятный и 
// понятный интерфейс – вашей программой будет пользоваться профессионал журналистики

namespace Task_3_1
{
    public class StartUp
    {
        public static void Main(string[] arg)
        {
            string inputString;
            char[] arrayOfDelimiters = new char[] { ' ', ',', '.', ':', ';', '!', '?', '-' };
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine
                (@"
            
▄▄▄█████▓▓█████ ▒██   ██▒▄▄▄█████▓    ██▓███   ▄▄▄       ██▀███    ██████ ▓█████  ██▀███  
▓  ██▒ ▓▒▓█   ▀ ▒▒ █ █ ▒░▓  ██▒ ▓▒   ▓██░  ██▒▒████▄    ▓██ ▒ ██▒▒██    ▒ ▓█   ▀ ▓██ ▒ ██▒
▒ ▓██░ ▒░▒███   ░░  █   ░▒ ▓██░ ▒░   ▓██░ ██▓▒▒██  ▀█▄  ▓██ ░▄█ ▒░ ▓██▄   ▒███   ▓██ ░▄█ ▒
░ ▓██▓ ░ ▒▓█  ▄  ░ █ █ ▒ ░ ▓██▓ ░    ▒██▄█▓▒ ▒░██▄▄▄▄██ ▒██▀▀█▄    ▒   ██▒▒▓█  ▄ ▒██▀▀█▄  
  ▒██▒ ░ ░▒████▒▒██▒ ▒██▒  ▒██▒ ░    ▒██▒ ░  ░ ▓█   ▓██▒░██▓ ▒██▒▒██████▒▒░▒████▒░██▓ ▒██▒
  ▒ ░░   ░░ ▒░ ░▒▒ ░ ░▓ ░  ▒ ░░      ▒▓▒░ ░  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ▒▓ ░▒▓░
    ░     ░ ░  ░░░   ░▒ ░    ░       ░▒ ░       ▒   ▒▒ ░  ░▒ ░ ▒░░ ░▒  ░ ░ ░ ░  ░  ░▒ ░ ▒░
  ░         ░    ░    ░    ░         ░░         ░   ▒     ░░   ░ ░  ░  ░     ░     ░░   ░ 
            ░  ░ ░    ░                             ░  ░   ░           ░     ░  ░   ░     
                                                                                          
               ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write
                (@"
  
   ______           _                     _                   _                   _                                 
 |  ____|         | |                   | |                 | |                 | |                              _ 
 | |__     _ __   | |_    ___   _ __    | |_    ___  __  __ | |_         _ __   | |   ___    __ _   ___    ___  (_)
 |  __|   | '_ \  | __|  / _ \ | '__|   | __|  / _ \ \ \/ / | __|       | '_ \  | |  / _ \  / _` | / __|  / _ \    
 | |____  | | | | | |_  |  __/ | |      | |_  |  __/  >  <  | |_   _    | |_) | | | |  __/ | (_| | \__ \ |  __/  _ 
 |______| |_| |_|  \__|  \___| |_|       \__|  \___| /_/\_\  \__| ( )   | .__/  |_|  \___|  \__,_| |___/  \___| (_)
                                                                  |/    | |                                        
                                                                        |_|                                        

                "+Environment.NewLine+ Environment.NewLine);



             inputString = Console.ReadLine();

            var words = new Dictionary<string, int>();

            string[] wordsArray = inputString.Split(arrayOfDelimiters, StringSplitOptions.RemoveEmptyEntries);

            int counter = 0;

            for (int i = 0; i < wordsArray.Length; ++i)
            {

                if (!words.ContainsKey(wordsArray[i].ToLower()))
                {
                    words.Add(wordsArray[i].ToLower(), 1);
                }
                else
                {
                    counter = words.GetValueOrDefault(wordsArray[i].ToLower());
                    ++counter;
                    words.Remove(wordsArray[i].ToLower());
                    words.Add(wordsArray[i].ToLower(), counter);
                    counter = 0;
                }
            }


            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " occurs " + word.Value + " time(s)");
            }

            bool unrepeatableText = true;

            foreach (var word in words)
            {
                if (word.Value > 10)
                {
                    unrepeatableText = false;
                }

            }


            if (unrepeatableText)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine
                    (@" 


  __  __                      _                   _            _   _  __     __                       _                                             _       _ 
 |  \/  |                    | |                 | |          | | | | \ \   / /                      | |                                           | |     | |
 | \  / | __ _ _ ____   _____| | ___  _   _ ___  | |_ _____  _| |_| |  \ \_/ /__  _   _    __ _  ___ | |_   _ __   ___    _ __ ___ _ __   ___  __ _| |_ ___| |
 | |\/| |/ _` | '__\ \ / / _ \ |/ _ \| | | / __| | __/ _ \ \/ / __| |   \   / _ \| | | |  / _` |/ _ \| __| | '_ \ / _ \  | '__/ _ \ '_ \ / _ \/ _` | __/ __| |
 | |  | | (_| | |   \ V /  __/ | (_) | |_| \__ \ | ||  __/>  <| |_|_|    | | (_) | |_| | | (_| | (_) | |_  | | | | (_) | | | |  __/ |_) |  __/ (_| | |_\__ \_|
 |_|  |_|\__,_|_|    \_/ \___|_|\___/ \__,_|___/  \__\___/_/\_\\__(_)    |_|\___/ \__,_|  \__, |\___/ \__| |_| |_|\___/  |_|  \___| .__/ \___|\__,_|\__|___(_)
                                                                                           __/ |                                  | |                         
                                                                                          |___/                                   |_|                         

                     ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine
                    (@" 

  _______           _           __ _           _                                                   
 |__   __|         | |         / _(_)         | |                                                  
    | |_ __ _   _  | |_ ___   | |_ _ _ __   __| |  ___ _   _ _ __   ___  _ __  _   _ _ __ ___  ___ 
    | | '__| | | | | __/ _ \  |  _| | '_ \ / _` | / __| | | | '_ \ / _ \| '_ \| | | | '_ ` _ \/ __|
    | | |  | |_| | | || (_) | | | | | | | | (_| | \__ \ |_| | | | | (_) | | | | |_| | | | | | \__ \
    |_|_|   \__, |  \__\___/  |_| |_|_| |_|\__,_| |___/\__, |_| |_|\___/|_| |_|\__, |_| |_| |_|___/
             __/ |                                      __/ |                   __/ |              
            |___/                                      |___/                   |___/               

                   ");
            }
            Console.ResetColor();
        }
    }
}
