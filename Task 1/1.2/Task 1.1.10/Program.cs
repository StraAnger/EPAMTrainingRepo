//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_10
    {

        static int[,] randomInitArray(int[,] inputArray)
        {
            Random rnd = new Random();

            for (int i = 0; i < inputArray.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1) + 1; ++j)
                {

                        inputArray[i, j] = rnd.Next() % 20 - 10;

                }
            }

            return inputArray;
        }
        static long sumOfEvenIndexElements(int[,] inputArray)
        {
            long sum = 0;

            for (int i = 0; i < inputArray.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1) + 1; ++j)
                {
                    if ((i+j)%2== 0)
                    sum+=inputArray[i, j];
                  
                }
            }
            return sum;
        }

        static void printArray(int[,] inputArray)
        {

            for (int i = 0; i < inputArray.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1) + 1; ++j)
                {
                        Console.Write(" " + inputArray[i, j] + " ");
                }
                Console.Write("\n");
            }


        }
        public static void Main(string[] args)
        {
           // Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его
           // позиций по обеим размерностям является чётным числом(например, [1,1] — чётная позиция, а
           //[1, 2] — нет). Определить сумму элементов массива, стоящих на чётных позициях

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            const int arraySize = 3;

            int[,] arrayOfInts = new int[arraySize, arraySize];

            randomInitArray(arrayOfInts);

            Console.WriteLine("New array is: ");
            printArray(arrayOfInts);

            Console.Write("Sum of even index elements: ");
            Console.WriteLine(sumOfEvenIndexElements(arrayOfInts));

            Console.ResetColor();
        }
    }
}





