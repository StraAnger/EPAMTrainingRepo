//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_7
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
        static int arraySearchMin(int[] inputArray)
        {

            int minElement = inputArray[0];

            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (inputArray[i] < minElement)
                    minElement = inputArray[i];
            }
        return minElement;
        }

        static int arraySearchMax(int[] inputArray)
        {

            int maxElement = inputArray[0];

            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (inputArray[i] > maxElement)
                    maxElement = inputArray[i];
            }
            return maxElement;
        }

        static int[] arraySort(int[] inputArray)
        {
            int buffer;

            for (int i = 0; i < inputArray.Length; ++i)
            {
                for (int j = i + 1; j < inputArray.Length; ++j)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        buffer = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = buffer;
                    }
                }
            }
            return inputArray;
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
            //Написать программу, которая генерирует случайным образом элементы массива(число элементов
            //в массиве и их тип определяются разработчиком), определяет для него максимальное и
            //минимальное значения, сортирует массив и выводит полученный результат на экран.
            //Примечание: LINQ запросы и готовые функции языка(Sort, Max и т.д.) использовать в данном
            //задании запрещается.

           Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            const int arraySize = 10;

            int[] arrayOfInts = new int[arraySize];

            randomInitArray(arrayOfInts);

            Console.Write("New array is: ");
            printArray(arrayOfInts);

            Console.Write("\nMax element is: ");
            Console.WriteLine(arraySearchMax(arrayOfInts));

            Console.Write("Min element is: ");
            Console.WriteLine(arraySearchMin(arrayOfInts));

            arraySort(arrayOfInts);

            Console.Write("Sorted array is: ");
            printArray(arrayOfInts);


            Console.ResetColor();
        }
    }
}





