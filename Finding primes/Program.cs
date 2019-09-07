using System;
using System.Collections.Generic;
using System.Linq;

namespace Finding_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases;

            Console.WriteLine("Write number of test cases:");
            if (!int.TryParse(Console.ReadLine(), out testCases))
            {
                Console.WriteLine("Integers only are allowed.");
                return;
            } else if (testCases == 0)
            {
                Console.WriteLine("No test cases to check.");
                return;
            }

            int[,] intervals = new int[testCases, 2];

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine($"Write beginning number of the {i +1} interval:");
                if (!int.TryParse(Console.ReadLine(), out intervals[i, 0]))
                {
                    Console.WriteLine("Integers only are allowed.");
                    return;
                }

                Console.WriteLine($"Write ending number of the {i + 1} interval:");
                if (!int.TryParse(Console.ReadLine(), out intervals[i, 1]))
                {
                    Console.WriteLine("Integers only are allowed.");
                    return;
                }
            }

            Console.WriteLine("Number of primes in set intervals:");
            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(findingPrimes(intervals[i, 0], intervals[i, 1]));
            }
            Console.ReadLine();
        }

        static int findingPrimes(int begin, int end)
        {
            bool[] primesArray = new bool[end];

            for (int i = 2; i < Math.Sqrt(end); i++)
            {
                if (primesArray[i] == false)
                {
                    int iterator = 0;
                    for (int j = 0; iterator < primesArray.Length; j++)
                    {
                        primesArray[iterator] = true;
                        iterator = ((int)Math.Pow(i, 2)) + (i * j);
                    }
                }
            }

            for (int y = 0; y < primesArray.Length && y < 2; y++)
            {
                primesArray[y] = true;
            }

            return primesArray.Skip(begin).Count(x => !x);
        }
    }
}
