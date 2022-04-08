//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_2
{
    public class Task_1_2_1
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая определяет среднюю длину слова во введённой текстовой строке. 
            //Учтите, что символы пунктуации на длину слов влиять не должны.Не стоит искать каждый
            //символ - разделитель вручную: пожалейте своё время и используйте стандартные методы классов
            //String и Char.
            //Регулярные выражения не использовать.
            //В случае дробного результата(х.5) – можете как оставить его таким, так и округлить.Стоит
            //оставить комментарий в коде, указывающий, какое решение вы приняли.
            //ВВОД: Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со
            //студентами в чате
            //ВЫВОД: 6

            double averageWordsLength=0;
            int counter = 0;
            string inputString;
            char[] arrayOfDelimiters = new char[] { ' ', ',', '.', ':', ';', '!', '?', '-' };

            Console.Write("Enter text, please: ");
            inputString= Console.ReadLine();

            string[] wordsArray = inputString.Split(arrayOfDelimiters, StringSplitOptions.RemoveEmptyEntries);
                       
            for (int i = 0; i < wordsArray.Length; ++i,++counter)
            {
                averageWordsLength+=wordsArray[i].Length;
            }


            //output number would be rounded

            Console.Write($"Average words length is {Math.Round(averageWordsLength/counter)} ");

        }
    }
}