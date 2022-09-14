/* This is a C# program to find the factors of a number. */
using System;

namespace ConsoleApp
{
    public class fact
    {
        public static void Main9(string[] args)
        {
            Console.Write("Enter the number which you want to find factor:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factor is:" + i);
                }
            }
        }
    }
}