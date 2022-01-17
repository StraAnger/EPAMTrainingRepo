//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_3
    {
        public static void Main(string[] args)
        {
            //Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее 
            //«изображение», состоящее из N строк:

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Enter the N number, please: ");
            string inputStringN = Console.ReadLine();

            int stringsNumberN;

            if (Int32.TryParse(inputStringN, out stringsNumberN))

                if (stringsNumberN <= 0)
                {
                    Console.WriteLine("Error input! Zero or negative input! ");
                }


            for (int i = 1; i <= stringsNumberN; ++i)
            {

                for (int j = 0; j < stringsNumberN; ++j)
                {
                    if (j >= stringsNumberN - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 0; j < i-1; ++j)
                {
                    Console.Write("*");
                }

                Console.Write("\n");

            }

            Console.ResetColor();
        }
    }
}