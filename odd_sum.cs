// program to calculate odd sum in a number
using System;
class odd_sum
{
    static void Main23(string[] args)
    {
        int n, sum = 0;
        Console.WriteLine("Enter a number"); 
        n = Convert.ToInt32(Console.ReadLine());
        while (n > 0) 
        {
            int r = n % 10; 
            if (r % 2 != 0) 
            {
                sum = sum + r; 
            }
            n = n / 10;
        }
        Console.WriteLine("Sum of odd numbers is"+sum);
    }
}