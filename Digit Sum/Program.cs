using System;
using System.Collections.Generic;
using System.Linq;

namespace Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;

            Console.WriteLine("Set a length of the array:");
            if (!Int32.TryParse(Console.ReadLine(), out arraySize))
            {
                Console.WriteLine("Array length must be an integer.");
                return;
            };

            Console.WriteLine("Type your numbers:");

            Console.WriteLine(sumOfdigits(Console.ReadLine(), arraySize));
            Console.ReadLine();
        }

        private static string sumOfdigits(string str, int arraySize)
        {
            var arrayOfInts = str.Split(" ");
            List<int> sumOnPosition = new List<int>();

            foreach (var item in arrayOfInts)
            {
                var sum = 0;
                foreach (var character in item)
                {
                    if(int.TryParse(character.ToString(), out int digit))
                    {
                        sum += digit;
                    }
                    else
                    {
                        return "Sequence contains non int value.";
                    }
                }
                sumOnPosition.Add(sum);
            }

            return (sumOnPosition.LastIndexOf(sumOnPosition.Max()) + 1).ToString();
        }
    }
}
