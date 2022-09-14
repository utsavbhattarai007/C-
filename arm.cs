/* A C# program to check whether a number is an Armstrong number or not. */
using System;
namespace ConsoleApp
{
    public class arm
    {
        public static void Main(string[] args)
        {
            int num, temp, rem, sum = 0;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is an Armstrong number");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong number");
            }
        }
    }
}