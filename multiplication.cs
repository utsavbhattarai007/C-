
using System;
public class multiplication
{
    static void Main()
    {
        int[,] arr1 = new int[3, 3];
        int[,] arr2 = new int[3, 3];
        int[,] m = new int[3, 3];
        Console.WriteLine("Enter the element of first matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the element of second matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                m[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    m[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        Console.WriteLine("The product of the two matrices is :");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
