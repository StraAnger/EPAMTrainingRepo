using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_3_2
{


    public class StartUp
    {

        public static void Main(string[] arg)
        {

            DynamicArray<string> testArray = new DynamicArray<string>();


            for (int i = 0; i < 10; ++i)
            {
                testArray.Add($"Word+ {i}");
            }

            DynamicArray<string> testArray3 = new DynamicArray<string>(testArray, testArray.Length);

            DynamicArray<string> testArray4 = new DynamicArray<string>();

            testArray4 = testArray3;

            testArray3.Insert(5, "Insertion");
            testArray3.Remove("Word+ 6");
            testArray3.AddRange(testArray4, testArray4.Length);


            foreach (var item in testArray3)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(testArray3.Capacity);
            Console.WriteLine(testArray3.Length);

        }

    }

}
