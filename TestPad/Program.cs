using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPad
{
    class Program
    {
        static void Main(string[] args)
        {
            double? max;
            List<int?> numberList = new List<int?>() { };

            try
            {
                max = CalculateMaxNumber(numberList);
                Console.WriteLine($"The max is " + max);
            }
            catch (Exception e) {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
        }

        private static double? CalculateMaxNumber(List<int?> numberList)
        {
            double? max;
            if (numberList.Count == 0)
            {
                throw new Exception("Numberlist did not contain any items");
            }

            max = numberList.Max();
            return max;
        }
    }
}
