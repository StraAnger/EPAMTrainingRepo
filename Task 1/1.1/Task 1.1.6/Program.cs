//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_1
{
    public class Task_1_1_6
    {

        static void DrawText(string statusString)
        {

            Console.Write("Параметры надписи:  ");
            Console.Write(statusString);
            Console.WriteLine("\nВведите: ");
            Console.WriteLine("\t 1: bold ");
            Console.WriteLine("\t 2: italic ");
            Console.WriteLine("\t 3: underline ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t or exit ");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static string CurrentStatus(int changeStatus,ref int[] currentStatusArray)
        {
            string outputString="";

            string firstParam = "";
            string firstComa = ""; 
            string secondParam = "";
            string secondComa = "";
            string thirdParam = "";

            ///////////////////////////////////////////////////
            /// Change current status by input from keyboard///
            ///////////////////////////////////////////////////
            
            switch (changeStatus)
            {
                case 1:
                    if (currentStatusArray[0] == 0)
                    {
                        currentStatusArray[0] = 1;
                    }
                    else
                    {
                        currentStatusArray[0] = 0;
                    }
                    break;
                case 2:
                    if (currentStatusArray[2] == 0)
                    {
                        currentStatusArray[2] = 1;
                    }
                    else
                    {
                        currentStatusArray[2] = 0;
                    }
                    break;
                case 3:
                    if (currentStatusArray[4] == 0)
                    {
                        currentStatusArray[4] = 1;
                    }
                    else
                    {
                        currentStatusArray[4] = 0;
                    }
                    break;

            }

            ///////////////////////////////////////////////////
            /// Decide whether to put a coma sign or not    ///
            ///////////////////////////////////////////////////

            //firstly, remove all comas

            if (currentStatusArray[0] == 0 && currentStatusArray[2] != 0 && currentStatusArray[4] != 0)
            {
                currentStatusArray[1] = 0;
                currentStatusArray[3] = 0;
            }
            
            if (currentStatusArray[0] != 0 && (currentStatusArray[2] == 0 || currentStatusArray[4] == 0))
            {
                currentStatusArray[3] = 0;
            }
            
            if (currentStatusArray[0] != 0 && (currentStatusArray[2] == 0 || currentStatusArray[4] == 0))
            {
                currentStatusArray[1] = 0;
            }
            
            if (currentStatusArray[0] == 0 && currentStatusArray[2] != 0 && currentStatusArray[4] == 0)
            {
                currentStatusArray[1] = 0;
                currentStatusArray[3] = 0;
            }
            
            if (currentStatusArray[0] == 0 && currentStatusArray[2] == 0 && currentStatusArray[4] != 0)
            {
                currentStatusArray[1] = 0;
                currentStatusArray[3] = 0;
            }

            //put commas

            if (currentStatusArray[0]!=0&& currentStatusArray[2]!=0)
            {
                currentStatusArray[1] = 1;
            }

            if (currentStatusArray[2] != 0 && currentStatusArray[4] != 0)
            {
                currentStatusArray[3] = 1;
            }

            if (currentStatusArray[0] != 0 && currentStatusArray[4] != 0)
            {
                currentStatusArray[3] = 1;
            }

            ////////////////////////////////////////////////////////
            ///Form a phrase components according to status array///
            ////////////////////////////////////////////////////////



            if (currentStatusArray[0] != 0)
            {
                firstParam = "bold";
            }
            if (currentStatusArray[1] != 0)
            {
                firstComa = ", ";
            }
            if (currentStatusArray[2] != 0)
            {
                secondParam = "italic";
            }
            if (currentStatusArray[3] != 0)
            {
                secondComa = ", ";
            }
            if (currentStatusArray[4] != 0)
            {
                thirdParam = "underline";
            }


            outputString=firstParam+firstComa+secondParam+secondComa+thirdParam;

            if (outputString == "")
              outputString = "none";
            

           return outputString;
        }

        static int StringToInt(string inputString)
        {
            int intFromString;

            if (Int32.TryParse(inputString, out intFromString))

                if (intFromString <= 0)
                {
                    Console.WriteLine("Error input! Zero or negative input! ");
                }


            return intFromString;
        }
        public static void Main(string[] args)
        {
            //Для форматирования текста надписи можно использовать различные начертания: полужирное, 
            //курсивное и подчёркнутое, а также их сочетания. Предложите способ хранения информации о
            //форматировании текста надписи и напишите программу, которая позволяет устанавливать и
            //изменять начертание:


            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;

            string consoleInputString = "";

            int[] statusArray = new int[5] { 0, 0, 0, 0, 0 };

            while (consoleInputString!="exit")
            {

                DrawText(CurrentStatus(StringToInt(consoleInputString),ref statusArray));
                consoleInputString = Console.ReadLine();
            }
            
            Console.ResetColor();
        }
    }
}