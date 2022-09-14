//palindrome using c sharp
using System;
namespace ConsoleApp
{
    public class palin
    {
        public static void Main17(string[] args)
        {
            int num, rev = 0, temp;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }
        }
    }
}