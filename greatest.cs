using System;

namespace ConsoleApp
{
    public class greatest
    {
        public static void Main10(string[] args)
        {
            int a=10,b=40,c=30;
            if(a>b && a>c)
            {
                Console.WriteLine("a is greatest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("b is greatest");
            }
            else
            {
                Console.WriteLine("c is greatest");
            }
        }
    }
}