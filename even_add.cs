/* A program to find the sum of even digits in a number. */
using System;

namespace ConsoleApp
{
    public class even_add
    {
        public static void Main22(string[] args)
        {
            Console.WriteLine("Enter the multi digit number"); //1234
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0) //1234>0, 123>0, 12>0, 1>0, 0>0
            {
                int r = n % 10; //4, 3, 2, 1, 0
                if (r % 2 == 0) //4%2==0, 3%2!=0, 2%2==0, 1%2!=0, 0%2==0
                {
                    sum = sum + r; //4, 6, 6, 6, 6
                }
                n = n / 10; //1234/10=123, 123/10=12, 12/10=1, 1/10=0
            }
            {
                int r = n % 10; //4
                if (r % 2 == 0)
                {
                    sum = sum + r; //4
                }
               n=n/10; //123
            }
            Console.WriteLine("The sum of even digits is:" + sum);
        }
    }
}