using System;
using System.Collections;
using System.Text;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            string array;
            Console.WriteLine("Set a length of the array:");
            if (!Int32.TryParse(Console.ReadLine(), out arraySize))
            {
                Console.WriteLine("Array length must be an integer.");
                return;
            };

            Console.WriteLine("Type your numbers:");

            Console.WriteLine(reverseOrder(Console.ReadLine(), arraySize).ToString());
            Console.ReadLine();
        }

        static string reverseOrder(string stringArray, int stringArraySize)
        {
            var arrayFromString = stringArray.Split(" ");
            Array.Reverse(arrayFromString);
            StringBuilder sb = new StringBuilder();
            foreach(var item in arrayFromString)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
