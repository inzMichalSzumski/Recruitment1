using System;
using System.Linq;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string array1;
            string array2;
            Console.WriteLine("Type first array:");
            array1 = Console.ReadLine();
            Console.WriteLine("Type second array:");
            array2 = Console.ReadLine();

            Console.WriteLine(isPermutation(stringArraytoIntArray(stringToArray(array1)), stringArraytoIntArray(stringToArray(array2))));
            Console.ReadLine();
        }

        static string[] stringToArray(string str)
        {
            return str.Split(" ");
        }

        static int[] stringArraytoIntArray(string[] arrayOfStings)
        {
            return Array.ConvertAll(arrayOfStings, x => int.Parse(x));            
        }

        static string isPermutation(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);

            if (arr1.SequenceEqual(arr2))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
