//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_1
    {
        public static void Main(string[] args)
        {
            //Написать программу, которая определяет площадь прямоугольника со сторонами a и b. Если
            //пользователь вводит некорректные значения(отрицательные или ноль), должно выдаваться
            //сообщение об ошибке.Возможность ввода пользователем строки вида «абвгд» или нецелых чисел
            //игнорировать.

            Console.WriteLine("Enter side a of rectangle: ");
            string inputStringA = Console.ReadLine();

            int rectangleSideA;

            if (Int32.TryParse(inputStringA, out rectangleSideA))
                
            if (rectangleSideA<= 0)
            {
                Console.WriteLine("Error input! Zero or negative input! ");
            }

            Console.WriteLine("Enter side b of rectangle: ");
            string inputStringB = Console.ReadLine();

            int rectangleSideB;

            if (Int32.TryParse(inputStringB, out rectangleSideB))

                if (rectangleSideB <= 0)
                {
                    Console.WriteLine("Error input! Zero or negative input! ");
                }

            if (rectangleSideA * rectangleSideB != 0)
            {
                Console.WriteLine("The square of rectangle is: ");
                Console.WriteLine(rectangleSideA * rectangleSideB);
            }
            else
            {
                Console.WriteLine("There was some errors in input, couldn't calculate sqare.");
            }
        }
    }
}