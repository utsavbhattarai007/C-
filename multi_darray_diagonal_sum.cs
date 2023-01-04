using System;
namespace abc
{
    public class multi_darray_diagonal_sum
    {
        public static void Main56(String[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the row and column size of the array:");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of diagonal elements is " + sum);
        }
    }
}
