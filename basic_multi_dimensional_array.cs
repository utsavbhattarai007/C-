using System;
namespace multidimensional_array
{
    public class basic_multi_dimensional_array
    {
        public static void Main54(String[] args)
        {
            int[,] arr = new int[3, 3];
            int i, j;
            Console.WriteLine("Enter the elements of array:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The elements of array are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}