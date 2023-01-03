/* A C# program that takes a multi digit number and adds the middle digits together. */
// using System;

// namespace ConsoleApp
// {
//     public class middle_sum
//     {
//         public static void Main(string[] args)
//         {
//             Console.Write("Enter the multi digit number:");
//             int n = Convert.ToInt32(Console.ReadLine()); 
//             int sum = 0;
//             n=n/10; 
//             while(n>=10) 
//             {
//               sum = + (n%10); 
//               n=n/10;
//             }
//             Console.WriteLine("The sum of middle digits is:"+sum);

//         }
//     }
// }
using System;
namespace abc {
    public class middle_sum{
        public static void Main51(string[] args){
            Console.WriteLine("Enter the multi digit number:");
            int num = Convert.ToInt32(Console.ReadLine());
            num = num / 10;
            int sum = 0;
            while(num >= 10){
                sum = sum + (num%10);
                num=num/10;
            }
            Console.WriteLine("The sum of multi digit number is:"+ sum);

        }
    }
}