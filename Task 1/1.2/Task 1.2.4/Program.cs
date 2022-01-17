//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Task_1_2
{
    public class Task_1_2_4
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая заменяет первую букву первого слова в предложении на заглавную.
            //В качестве окончания предложения можете считать только «.|?| !». Многоточие и «?!» можете
            //опустить.
            //Пример:
            //ВВОД: я плохо учил русский язык.забываю начинать предложения с заглавной.хорошо, что можно написать
            //программу!
            //ВЫВОД: Я плохо учил русский язык.Забываю начинать предложения с заглавной.Хорошо, что можно
            //написать программу!

            string inputString;

            Console.Write("Enter text, please: ");
            inputString = Console.ReadLine();

            inputString = inputString.Insert(0, Char.ToString(inputString[0]).ToUpper());
            inputString = inputString.Remove(1, 1);

            for (int i = 0; i < inputString.Length; ++i)
            {

                //Check whether there is a space after delimiter or it isn't


                if((inputString[i] == '.'|| inputString[i] == '!'|| inputString[i] == '?')&&(i+1!=inputString.Length))
                {
                    if (inputString[i +1] != ' ')
                    {
                        inputString = inputString.Insert(i + 1, Char.ToString(inputString[i + 1]).ToUpper());
                        inputString = inputString.Remove(i+2, 1);
                                                
                    }
                    else if (inputString[i +1] == ' ')
                    {
                        inputString = inputString.Insert(i + 2, Char.ToString(inputString[i + 2]).ToUpper());
                        inputString = inputString.Remove(i+3, 1);
                    }
                }
            }

        Console.WriteLine(inputString);

        }
    }
}