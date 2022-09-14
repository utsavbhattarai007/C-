/* A C# program that takes a multiple digit number and adds the first and last digit of the number. */
using System;

namespace ConsoleApp
{
    public class first_last_sum
    {
        public static void Main12(string[] args)
        {
            Console.WriteLine("Enter the multiple digit number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int l = n%10; 
            while(n>=10)
            {
                n=n/10; 
            }
            int sum = n+l;
            Console.Write("The sum of first and last digit is:"+sum);
        }
    }
}