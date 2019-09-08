using System;

public class Class1
{
	public static Class1()
	{
        public static string[] stringToArray(string str)
        {
            return str.Split(" ");
        }

        public static int[] stringArraytoIntArray(string[] arrayOfStings)
        {
            return Array.ConvertAll(arrayOfStings, x => int.Parse(x));
        }
    }
}
