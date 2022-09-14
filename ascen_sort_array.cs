// program to sort array in ascending order in c sharp
using System;
namespace ConsoleApp
{
    public class ascen_sort_array
    {
        public static void Main15(string[] args)
        {
            int[] arr = new int[5];
            int temp;
            Console.WriteLine("Enter the elements of array:"); //4 6 9 2 1
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i] > arr[j]) 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array in ascending order is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}