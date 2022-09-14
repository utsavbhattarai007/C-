using System;
namespace abc
{
    public class series
    {
         static void Main4(String[] args)
        {
            int a=2,b=0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(a);
                ++b;
                a = a + b;
            }
        }
    }
}