//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_8
    {

        static int[,,] randomInitArray(int[,,] inputArray)
        {
            Random rnd = new Random();

            for (int i = 0; i < inputArray.GetUpperBound(0)+1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1)+1; ++j)
                {
                    for (int k = 0; k < inputArray.GetUpperBound(2)+1; ++k)
                    {
                        inputArray[i, j, k] = rnd.Next() % 20 - 10;
                    }
                }
            }

            return inputArray;
        }
        static int[,,] arrayReplacePositiveToZeroes(int[,,] inputArray)
        {
            for (int i = 0; i < inputArray.GetUpperBound(0)+1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1)+1; ++j)
                {
                    for (int k = 0; k < inputArray.GetUpperBound(2)+1; ++k)
                    {
                        if (inputArray[i,j,k] > 0)
                            inputArray[i, j, k]=0;
                    }
                }
            }
            return inputArray;
        }

        static void printArray(int[,,] inputArray)
        {

            for (int i = 0; i < inputArray.GetUpperBound(0)+1; ++i)
            {
                for (int j = 0; j < inputArray.GetUpperBound(1)+1; ++j)
                {
                    for (int k = 0; k < inputArray.GetUpperBound(2)+1; ++k)
                    {
                        Console.Write(" " + inputArray[i,j,k] + " ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


        }
        public static void Main(string[] args)
        {
            //Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на
            //нули.Число элементов в массиве и их тип определяются разработчиком.

           Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            const int arraySize = 3;

            int[,,] arrayOfInts = new int[arraySize, arraySize, arraySize];

            randomInitArray(arrayOfInts);

            Console.WriteLine("New array is: ");
            printArray(arrayOfInts);

            arrayReplacePositiveToZeroes(arrayOfInts);

            Console.WriteLine("All positive elements were replaced on 0: ");
            printArray(arrayOfInts);


            Console.ResetColor();
        }
    }
}





