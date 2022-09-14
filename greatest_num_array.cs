/* A C# program to find the greatest number in an array. */
using System;

namespace ConsoleApp
{
    public class greatest_num_array
    {
        public static void Main14(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter the elements of array:");
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int greatest = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>greatest)
                {
                    greatest = arr[i];
                }
            }
            Console.WriteLine("The greatest number in the array is "+greatest);
        }
    }
}