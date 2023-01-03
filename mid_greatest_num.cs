/* The program finds the middle number in three numbers */
using System;
class middle_greatest_number
{
    static void Main16(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter three numbers");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        if (a > b && a < c || a < b && a > c)
        {
            Console.WriteLine("The middle number is " + a);
        }
        else if (b > a && b < c || b < a && b > c)
        {
            Console.WriteLine("The middle number is " + b);
        }
        else
        {
            Console.WriteLine("The middle number is " + c);
        }
    }
}