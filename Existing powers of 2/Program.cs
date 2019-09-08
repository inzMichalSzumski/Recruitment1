using System;
using System.Collections.Generic;
using System.Linq;

namespace Existing_powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = new List<int>();

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int integer))
                {
                    return;
                }
                else
                {
                    integersList.Add(integer);
                }
                Console.Clear();
                Console.WriteLine("Given numbers: ");
                foreach (var item in integersList)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Result: ");
                Console.WriteLine();
                foreach(var item in prepareDecompositionList(integersList))
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Type non integer value to exit the program.");
            }
        }

        static List<int> prepareDecompositionList(List<int> integers)
        {
            var results = new List<int>();
            List<int> listOfPowersOf2 = GenerateListOfPowers(integers);

            foreach (var item in integers)
            {
                results.AddRange(decomposition(item, listOfPowersOf2));
            }
            results = results.Distinct().ToList();
            results.Sort();
            return results;
        }

        private static List<int> GenerateListOfPowers(List<int> integers)
        {
            var max = integers.Max();
            var listOfPowersOf2 = new List<int>();
            var iterator = 0;
            while (true)
            {
                var currentPower = (int)Math.Pow(Convert.ToDouble(2), Convert.ToDouble(iterator));

                if (currentPower > max)
                {
                    break;
                }

                listOfPowersOf2.Add(currentPower);
                iterator++;
            }

            return listOfPowersOf2;
        }

        static List<int> decomposition(int number, List<int> powers)
        {
            List<int> parts = new List<int>();
            for (int i = powers.Count - 1; i >= 0; i--)
            {
                if (number >= powers[i])
                {
                    parts.Add(powers[i]);
                    number -= powers[i];
                }
            }
            return parts;
        }
    }
}
