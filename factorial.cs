/* This is a C# program to find the factorial of a number. */
using System;

namespace ConsoleApp
{
    public class factor
    {
        public static void Main8(string[] args)
        {
           Console.WriteLine("Enter the number for factorial");
           int n = Convert.ToInt32(Console.ReadLine());
           int fact =1;
           for(int i=1;i<=n;i++)
           {
            fact =fact * i;
           }
              Console.WriteLine("Factorial of "+n+" is "+fact);
        }
    }
}