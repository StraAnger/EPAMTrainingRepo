    //using System;
    //using System.Collections.Generic;
    //using System.Linq;

namespace Task_1_2
{
    public class Task_1_2_3
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая считает количество слов, начинающихся с маленькой буквы. 
            //Предлоги, союзы и междометия считаются словами.Финальную точку в предложении(как и любой
            //другой знак) можно не учитывать.
            //Вариант без *-разделителем между словами считать ТОЛЬКО пробелы
            //Вариант со * -разделители между словами могут быть любые: запятые, двоеточия, точки с
            //запятой.
            //Пример без *:
            //ВВОД: Антон выпил кофе и послушал Стинга
            //ВЫВОД: 4
            //Пример со *:
            //ВВОД: Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны
            //ВЫВОД: 8

            int wordsFirstLetterInLowerCase = 0;
            
            string inputString;
            char[] arrayOfDelimiters = new char[] { ' ', ',', '.', ':', ';', '!', '?', '-' };

            Console.Write("Enter text, please: ");
            inputString = Console.ReadLine();

            string[] wordsArray = inputString.Split(arrayOfDelimiters, StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < wordsArray.Length; ++i)
            {
                char[] charArray = wordsArray[i].ToCharArray();

                if (char.IsLower(charArray[0]))
                {
                    ++wordsFirstLetterInLowerCase;
                }
            }

            // The hard ( * ) variant

        Console.WriteLine($"Number of words that starts with a low case is {wordsFirstLetterInLowerCase} ");

        }
    }
}