using System;
using System.Text;

namespace Task_2_1;

public class Task_2_1_1
{

    public static void Main(string[] arg)
    {

        //Напишите собственный класс, описывающий строку как массив символов. Реализуйте для этого 
        //класса типовые операции (сравнение, конкатенация, поиск символов, конвертация из/в массив 
        //символов). Подумайте, какие функции вы бы добавили к имеющемуся в .NET функционалу строк 
        //(достаточно 1-2 функций).
        //Вариант со * - подумайте над использованием в своем классе функционала индексатора 
        //(indexer). Реализуйте его для своей строки. 
        //Вариант с ** - попробуйте создать из своей сборки переносимую библиотеку (DLL). Осмысленно
        //назовите её, а также namespace и сам класс.Попробуйте использовать написанный вами класс в
        //другом проекте.


        Console.WriteLine("Enter the 1st string:");

        CharString String1 = new CharString(Console.ReadLine().ToCharArray());

        Console.WriteLine("Enter the 2nd string:");

        CharString String2 = new CharString(Console.ReadLine().ToCharArray());

        String1.StringOutput();
        String2.StringOutput();

        Console.WriteLine(String1.IsEqual(String2));

        (String1 + String2).StringOutput();

        Console.WriteLine("Enter character to look for: ");


        char.TryParse(Console.ReadLine(), out char inputCharacter);

        Console.WriteLine($"Index of {inputCharacter} char in String1: {String1.IndexOfChar(inputCharacter)}");

        Console.WriteLine($"Index of {inputCharacter} char in String2: {String2.IndexOfChar(inputCharacter)}");


        Console.WriteLine($"Length of String1 is: {String1.LengthOfString()}");
        Console.WriteLine($"Length of String2 is: {String2.LengthOfString()}");

        Console.WriteLine($"Number of spaces in String1 is: {String1.CountSpaces()}");
        Console.WriteLine($"Number of spaces in String2 is: {String2.CountSpaces()}");
    }
}