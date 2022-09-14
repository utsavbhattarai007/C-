using System;
namespace ConsoleApp
{
    public class salary
    {
        public static void Main2(string[] args)
        {
            int salary,tax,bonus,newSalary,salaryBouns;
            Console.Write("Enter the salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            if(salary <= 10000)
            {
                bonus = (5 * salary) / 100;
                salaryBouns = salary + bonus;
                tax = (10 * salaryBouns) / 100;
                newSalary = salaryBouns - tax;
                Console.WriteLine("The new salary is:" + newSalary);
            } 
            else{
                bonus = (10 * salary) / 100;
                salaryBouns = salary + bonus;
                tax = (20 * salaryBouns) / 100;
                newSalary = salaryBouns - tax;
                Console.WriteLine("The new salary is:" + newSalary);
            }           
        }
    }
}