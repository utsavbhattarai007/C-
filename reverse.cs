using System;

namespace ConsoleApp
{
    public class reverse
    {
        public static void Main20(string[] args)
        {
            Console.Write("Enter a multi digit number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0; //123
            while (num > 0)
            {
                rev = rev * 10 + num % 10; //0+3=3, 30+2=32, 320+1=321
                num = num / 10;// 12, 1, 0
            }
            Console.WriteLine("The reverse of the number is " + rev);
        }
    }
}