using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_3_3_2
{
    public delegate char StringAction(char param);

    public class StartUp
    {

        private static char LanguageDefine(char inputChar)
        {
            char _elementType = 'M';

            if (inputChar == 1025 || inputChar == 1105 || (inputChar >= 1040 && inputChar <= 1103)) _elementType = 'R';
            if ((inputChar >= 65 && inputChar <= 90) || (inputChar >= 97 && inputChar <= 122)) _elementType = 'E';
            if (inputChar >= 48 && inputChar <= 57) _elementType = 'N';

            return _elementType;
        }


        public static string AnalyzeString(string inputString, StringAction action)
        {
            string status = "Mixed";
            bool english = true;
            bool russian = true;
            bool number = true;


            for (int i = 0; i < inputString.Length; ++i)
            {
                if (!(action(inputString[i]) == 'E')) english = false;
                if (!(action(inputString[i]) == 'R')) russian = false;
                if (!(action(inputString[i]) == 'N')) number = false;

            }

            if (english) status = "English";
            if (russian) status = "Russian";
            if (number) status = "Number";

            return status;
        }



        public static void Main(string[] arg)
        {

            string testString = "текстдляпроверки";

            Console.WriteLine($"Output: {AnalyzeString(testString, LanguageDefine)}");


        }

    }

}
