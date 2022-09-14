using System;

namespace ConsoleApp
{
    public class calc
    {
        public static void Main(string[] args)
        {
            int a, b, c, ch;
            Console.Write("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.Write("Enter your choice:");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("The sum of two number is:" + c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("The subtraction of two number is:" + c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("The multiplication of two number is:" + c);
                    break;
                case 4:
                    c = a/b;
                    Console.WriteLine("The division of two number is:"+c);
                    break;
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}