// program to find reverse of a number in c sharp
using System;
namespace ConsoleApp
{
    class reversee
    {
        static void Main24(string[] args)
        {
            int n, rev = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.WriteLine("Reverse of the number is " + rev);
        }
    }
}