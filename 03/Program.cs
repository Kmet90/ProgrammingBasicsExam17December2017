using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int night = int.Parse(Console.ReadLine());
            string dest = Console.ReadLine();
            string transport = Console.ReadLine();
            var price = 0.0;
            var finalPrice = 0.0;
            var trPrice = 0.0;

            if (dest == "Miami") 
            {
                if (night <= 10) price = (night * (2 * 24.99 + 3 * 14.99));
                else if (night > 10 && night <= 15) price = (night * (2 * 22.99 + 3 * 11.99));
                else if (night > 15) price = (night * (2 * 20.00 + 3 * 10.00));
            }
            else if (dest == "Canary Islands")
            {
                if (night <= 10) price = (night * (2 * 32.50 + 3 * 28.50));
                else if (night > 10 && night <= 15) price = (night * (2 * 30.50 + 3 * 25.60));
                else if (night > 15) price = (night * (2 * 28.00 + 3 * 22.00));
            }
            else if (dest == "Philippines")
            {
                if (night <= 10) price = (night * (2 * 42.99 + 3 * 39.99));
                else if (night > 10 && night <= 15) price = (night * (2 * 41.00 + 3 * 36.00));
                else if (night > 15) price = (night * (2 * 38.50 + 3 * 32.40));
            }
            if (transport == "train") trPrice = 2 * 22.30 + 3 * 12.50;
            else if (transport == "bus") trPrice = 2 * 45.00 + 3 * 37.00;
            else if (transport == "airplane") trPrice = 2 * 90.00 + 3 * 68.50;

            finalPrice = price + price * 0.25 + trPrice;

            Console.WriteLine($"{finalPrice:f3}");
        }        
    }
}
