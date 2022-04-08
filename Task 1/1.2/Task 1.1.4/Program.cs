//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_4
    {

        static void drawScene(int numberOfTriangles)
        {
            for (int i = 1; i <= numberOfTriangles; ++i)
            {
                drawTriangle(i, numberOfTriangles - i);
            }
        }

        static void drawTriangle(int numberOfLines, int offset)
        {

            for (int i = 1; i <= numberOfLines; ++i)
            {

                for (int j = 0; j < offset; ++j)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < numberOfLines; ++j)
                {
                    if (j >= numberOfLines - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 0; j < i - 1; ++j)
                {
                    Console.Write("*");
                }
                Console.Write("\n");



            }

        }

        static int inputToInt(string inputStringN)
        {
            int stringsNumberN;

            if (Int32.TryParse(inputStringN, out stringsNumberN))

                if (stringsNumberN <= 0)
                {
                    Console.WriteLine("Error input! Zero or negative input! ");
                }


            return stringsNumberN;
        }
        public static void Main(string[] args)
        {
            //Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее 
            //«изображение», состоящее из N треугольников

            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;


            Console.WriteLine("Enter number of triangles ( N number ), please: ");

            drawScene(inputToInt(Console.ReadLine()));

            Console.ResetColor();
        }
    }
}