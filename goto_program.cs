using System;
namespace abc{
    public class goto_program{
        public static void Main56(String[] args){
         repeat:
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<18){
                Console.WriteLine("You are not eligible to vote");
                goto repeat;
            }
            Console.Write("You are eligible to vote");
        }
    }
}