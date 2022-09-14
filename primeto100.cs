using System;

namespace ConsoleApp
{
    public class prime
    {
        public static void Main6(string[] args)
        {
            bool check=true;
            for (int i = 2; i < 100; i++) 
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine(i);
                }
                check=true;
            }

        }
    }
}