/* A C# program to print the Fibonacci series. */
using System;

namespace ConsoleApp
{
    public class fibo
    {
        public static void Main7(string[] args)
        {
            Console.WriteLine("Enter the number of terms");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.Write(a + " " + b);
            for (int i = 0; i < n - 2; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }
    }
}