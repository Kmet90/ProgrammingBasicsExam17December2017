using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine().ToLower();
            int h = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            string dn= Console.ReadLine().ToLower();

            double price = 0.0;

            if (m == "march" || m == "april" || m == "may")
            {
                if (dn == "day") price = 10.50;
                else price = 8.4;
            }
            if (m == "august" || m == "july" || m == "june")
            {
                if (dn == "day") price = 12.60;
                else price = 10.20;
            }
            if (p >= 4) price = price - (price * 0.1);
            if (h >= 5) price = price - (price * 0.5);

            double fullPrice = price * p * h;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {fullPrice:f2}");
        }
    }
}
