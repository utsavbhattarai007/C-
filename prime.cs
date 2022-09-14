using System;
namespace abc{
    public class prime{
        static void Main5(String[] args){
            int a,b=0;
            Console.Write("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<a;i++){
                if(a%i==0){
                    b=1;
                    break;
                }
            }
            if(b==0){
                Console.WriteLine("The number is prime");
            }
            else{
                Console.WriteLine("The number is not prime");
            }
        }
    }
}