using System;
namespace abc
{
    public struct employee
    {
        public string name;
        public int salary;
        public int age;
        public string address;
    }
    public class structure
    {
        public static void Main53(string[] args)
        {
            Console.Write("Enter the no. of employee:");
            int n = Convert.ToInt32(Console.ReadLine());
            employee[] obj = new employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the name of employee of " + i + ":");
                obj[i].name = Console.ReadLine();
                Console.Write("Enter the age of employee of " + i + ":");
                obj[i].age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the address of employee of " + i + ":");
                obj[i].address = Console.ReadLine();
                Console.Write("Enter the salary of employee of " + i + ":");
                obj[i].salary = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the address you want to search:");
            string adr = Console.ReadLine();
            string newAdr = adr.ToLower();
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                string newAddress = obj[i].address.ToLower();
                if (newAddress.Equals(newAdr))
                {
                    flag = true;
                    Console.WriteLine(adr + " is the address of " + obj[i].name);
                }
            }
           if(flag == false){
            Console.Write("Address not found!");
           }
        }
    }
}