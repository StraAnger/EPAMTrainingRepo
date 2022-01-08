//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_9
    {

        static int[] randomInitArray(int[] inputArray)
        {
            Random rnd = new Random();

            for (int i = 0; i < inputArray.Length; ++i)
            {
                inputArray[i] = rnd.Next() % 20 - 10;
            }

            return inputArray;
        }
        static int countNegativeElements(int[] inputArray)
        {

            int counter = 0;

            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (inputArray[i] < 0)
                    ++counter;
            }
            return counter;
        }

        static void printArray(int[] inputArray)
        {

            for (int i = 0; i < inputArray.Length; ++i)
            {
                Console.Write(" " + inputArray[i] + " ");
            }

        }
        public static void Main(string[] args)
        {
            //Написать программу, которая определяет сумму неотрицательных элементов в одномерном
            //массиве.Число элементов в массиве и их тип определяются разработчиком.

           Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            const int arraySize = 10;

            int[] arrayOfInts = new int[arraySize];

            randomInitArray(arrayOfInts);

            Console.Write("New array is: ");
            printArray(arrayOfInts);

            Console.Write("\nNumber of negative elements is: ");
            Console.WriteLine(countNegativeElements(arrayOfInts));

            Console.ResetColor();
        }
    }
}





