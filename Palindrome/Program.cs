using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            Console.WriteLine("Type in a word:");
            word = Console.ReadLine();
            Console.WriteLine(Compare(word));
            Console.ReadLine();
        }

        static string Compare(string word)
        {
            word = Regex.Replace(word, "[^a-zA-Z]", "").ToLower();
            char[] charr = word.ToCharArray();
            Array.Reverse(charr);
            string word2 = new string(charr);           

            if (word.Equals(word2)) 
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
