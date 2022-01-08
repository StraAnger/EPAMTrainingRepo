//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_2
{
    public class Task_1_2_2
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая удваивает в первой введённой строке все символы, принадлежащие
            //второй введённой строке.
            //Пример:
            //ВВОД 1: написать программу, которая
            //ВВОД 2: описание
            //ВЫВОД: ннааппииссаать ппроограамму, коотоораая

            string inputString1,inputString2;

            Console.Write("Enter first line, please: ");
            inputString1 = Console.ReadLine();

            Console.Write("Enter second line, please: ");
            inputString2 = Console.ReadLine();

            int counter = 0;
            char[] charArray = inputString2.ToCharArray();

            //Remove duplicate chars, replace them with spaces

            for(int i = 0; i < charArray.Length; ++i)
            {
                char currentElement = charArray[i];

                for (int j = 1; j < charArray.Length; ++j)
                {
                    if ((charArray[j] == currentElement)&&(i!=j))
                    {
                        charArray[j] = ' ';
                    }
                }

            }
            
            foreach (char character in charArray)
            {
                if (character != ' ')
                {
                    for (int i = 0; i < inputString1.Length; ++i)
                    {
                        if (inputString1[i] == character)
                        {
                            inputString1 = inputString1.Insert(i, $"{character}");
                            ++i;
                        }
                    }
                }
           
            }
            Console.Write("Result line is: "+inputString1);
        }
    }
}