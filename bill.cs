//program to calculate electricity bill in c sharp
using System;
namespace ConsoleApp
{
    class bill
    {
        static void Main25(string[] args)
        {
            int units;
            double billpay = 0;
            Console.WriteLine("Enter the number of units consumed");
            units = Convert.ToInt32(Console.ReadLine());
            if (units < 100)
            {
                billpay = units * 1.20;
            }
            else if (units >= 100 && units < 300)
            {
                billpay = 100 * 1.20 + (units - 100) * 2;
            }
            else if (units >= 300 && units < 500)
            {
                billpay = 100 * 1.20 + 200 * 2 + (units - 300) * 3;
            }
            else
            {
                billpay = 100 * 1.20 + 200 * 2 + 200 * 3 + (units - 500) * 4;
            }
            Console.WriteLine("Bill to pay : " + billpay);
        }
    }
}