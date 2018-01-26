using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salary = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();

            decimal currSalary = salary;
            var counter = 1;

            for (int i = 1; i <= year; i++) 
            {
                
                currSalary = currSalary + (currSalary * 0.06m);
                if (counter == 5) currSalary = currSalary + 100m;
                if (counter == 10) currSalary = currSalary + 200m;
                counter++;               
            }

            if (a == "yes")
            {
                currSalary = currSalary - currSalary * 0.01m;
                if (counter == 5) currSalary = currSalary + currSalary * 0.01m;
                if (counter == 10) currSalary = currSalary + currSalary * 0.01m;
            }


            if (currSalary >= 5000)
            {
                Console.WriteLine($"Current salary: 5000.00");
                Console.WriteLine($"0 more years to max salary.");
            }
            else
            {
                Console.WriteLine($"Current salary: {currSalary:f2}");
                Console.WriteLine($"{counter - 3} more years to max salary.");

            }
        }
    }
}
