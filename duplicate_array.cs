//count the duplicate element in an array in c sharp
using System;
namespace ConsoleApp
{
    class duplicate_array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, j,  size, count = 0;
            Console.Write("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total number of duplicate elements is:");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}