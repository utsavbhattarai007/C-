// sum of two number in c sharp
using System;
namespace ConsoleApp
{
    public class sum
    {
        public static void Main1(string[] args)
        {
            int a, b, c;
            Console.Write("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("The sum of two number is:" + c);
        }
    }
}