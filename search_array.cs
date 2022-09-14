/* A program to search an element in an array. */
using System;

namespace ConsoleApp
{
    public class search_array
    {
        public static void Main00(string[] args)
        {
            /* This is asking the user to enter the size of the array. */
            Console.Write("Enter the size of array: ");
            int s = Convert.ToInt32(Console.ReadLine());

            /* This is creating an array of size s. */
            string[] arr = new string[s];

            /* This is asking the user to enter the elements of the array. */
            Console.WriteLine("Enter the elements like name,place etc of array:");
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = Console.ReadLine();
            }

            /* This is asking the user to enter the element to be searched. */
            Console.Write("Enter the element to be searched: ");
            string srh = Console.ReadLine();

            /* This is searching the element in the array. */
            int flag = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] == srh)
                {
                    flag = 1;
                    Console.WriteLine("Element found at index " +i+" which is "+arr[i]);
                    break;
                }
            }

            //If element is not found, It show this:
            if(flag == 0)
            {
                Console.WriteLine("Element not found");
            }

        }
    }
}