/* A C# program that takes a multi digit number and adds the middle digits together. */
using System;

namespace ConsoleApp
{
    public class middle_sum
    {
        public static void Main21(string[] args)
        {
            Console.Write("Enter the multi digit number");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int sum =0;
            n=n/10; 
            while(n>=10) 
            {
              sum=sum+(n%10); 
              n=n/10;
            }
            Console.WriteLine("The sum of middle digits is:"+sum);

        }
    }
}