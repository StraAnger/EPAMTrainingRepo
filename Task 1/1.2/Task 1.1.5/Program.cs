//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_5
    {
        public static void Main(string[] args)
        {
            //Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма 
            //этих чисел будет равна 23. Напишите программу, которая выводит на экран сумму всех чисел 
            //меньше 1000, кратных 3 или 5.

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            int sumOfNumbers = 0;

            for (int i = 0; i < 1000; ++i)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers += i;
                }

            }


            Console.WriteLine("Sum of numbers that divisible on 3 and 5 ( less than 1000) is : ");

            Console.WriteLine(sumOfNumbers);

            Console.ResetColor();
        }
    }
}





