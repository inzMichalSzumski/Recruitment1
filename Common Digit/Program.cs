using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Digit
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

            Console.WriteLine(digitCounter(Console.ReadLine(), arraySize));
            Console.ReadLine();
        }

        private static string digitCounter(string str, int arraySize)
        {
            Dictionary<int, int> occurencesOf = new Dictionary<int, int>();

            foreach(var currentChar in str.Replace(" ", ""))
            {
                if (int.TryParse(currentChar.ToString(), out int charint))
                {
                    if (!occurencesOf.ContainsKey(charint))
                    {
                        int charCount = str.Length - str.Replace(currentChar.ToString(), "").Length;
                        occurencesOf.Add(int.Parse(currentChar.ToString()), charCount);
                    }
                }
                else
                {
                    return "Sequence contains non int value.";
                }
            }

            return occurencesOf
                .OrderByDescending(x => x.Value)
                .ThenByDescending(y => y.Key)
                .FirstOrDefault()
                .Key
                .ToString();
        }
    }
}
