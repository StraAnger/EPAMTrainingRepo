using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_3_3_1
{
    public delegate double DoubleSimpleAction(double param);

    public delegate double DoubleAdvancedAction(double[] param);

    public class StartUp
    {

        private static double Divide(double element) => element / 2;

        private static double SumOfElements(double[] arrayInput)
        {
            double _sum = 0;
            for (int i = 0; i < arrayInput.Length; ++i) _sum += arrayInput[i];
            return _sum;
        }

        private static double AverageOfElements(double[] arrayInput)
        {
            double _sum = 0;
            int _count = 0;
            for (int i = 0; i < arrayInput.Length; ++i)
            {
                _sum += arrayInput[i];
                ++_count;
            }
            return _sum / _count;
        }

        private static double MostFrequentElement(double[] inputArray)
        {
            //  Returns -65536 if there is no frequent elements in array

            double _frequent = -65536;
            int _max = 1;
            int _counter = 0;
            var _arrayElementsFrequencyDictionary = new Dictionary<double, int>();

            for (int i = 0; i < inputArray.Length; ++i)
            {

                if (!_arrayElementsFrequencyDictionary.ContainsKey(inputArray[i]))
                {
                    _arrayElementsFrequencyDictionary.Add(inputArray[i], 1);
                }
                else
                {
                    _counter = _arrayElementsFrequencyDictionary.GetValueOrDefault(inputArray[i]);
                    ++_counter;
                    _arrayElementsFrequencyDictionary.Remove(inputArray[i]);
                    _arrayElementsFrequencyDictionary.Add(inputArray[i], _counter);
                    _counter = 0;
                }
            }
            foreach (var _element in _arrayElementsFrequencyDictionary)
            {
                if (_element.Value > _max)
                {
                    _max = _element.Value;
                    _frequent = _element.Key;
                }
            }

            return _frequent;
        }

        public static void ApplyToArray(double[] inputArray, DoubleSimpleAction action)
        {
            for(int i=0; i<inputArray.Length;++i)
                inputArray[i] = action(inputArray[i]);
        }


        public static double ApplyToArray(double[] inputArray, DoubleAdvancedAction action)
        {
            return action(inputArray);
        }



        public static void Main(string[] arg)
        {

            double[] testArray = { 2.5, 3.5, 2.5, 5.3, 6.2, 0, -15.5 };

       
            //foreach (var element in testArray)
            //{
            //    Console.WriteLine(element);
            //}

            Console.WriteLine($"Output: {ApplyToArray(testArray, MostFrequentElement)}");


        }

    }

}
