using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = int.Parse(Console.ReadLine());
            double r = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double sum = int.Parse(Console.ReadLine());

            double raz = dist * r / 100.0;
            double fullPrice = raz * price;

            if (sum >= fullPrice) 
            {
                double x = Math.Abs(sum - fullPrice);
                Console.WriteLine($"You can take a trip. {x:f2} money left.");
            }
            else if (sum < fullPrice)
            {
                double a = Math.Ceiling(fullPrice - sum);
                double y = a / 5.0;
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {y:f2} money.");
            }
        }
    }
}
