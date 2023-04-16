using System;
namespace abc
{
    public class pointers
    {
        public static void Main(String[] args)
        {
            pointers p = new pointers();
            p.method();
        }
        public unsafe void method()
        {
            int* a;
            int* b;
            int x = 20;
            int y = 30;
            a = &x;
            b = &y;
            Console.WriteLine("Value of a is:- " + *a);
            Console.WriteLine("Value of b is:- " + *b);
            Console.WriteLine("Address of a is:- " +  (int)a);
            Console.WriteLine("Address of b is:- " + (int)b);
        }

    }
}