//program to find middle number in three digit number in c sharp
using System;
namespace ConsoleApp
{
    public class mid_num
    {
        public static void Main50(string[] args)
        {
            int num, a, b, c;
            Console.Write("Enter a three digit number: ");
            num = Convert.ToInt32(Console.ReadLine());
            a = num / 100;
            b = (num / 10) % 10;
            c = num % 10;
            if (b > a && b < c || b < a && b > c)
            {
                Console.WriteLine("Middle digit is: " + b);
            }
            else if (a > b && a < c || a < b && a > c)
            {
                Console.WriteLine("Middle digit is: " + a);
            }
            else
            {
                Console.WriteLine("Middle digit is: " + c);
            }
        }
    }
}


