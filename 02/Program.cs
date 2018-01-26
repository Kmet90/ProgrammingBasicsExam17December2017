using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());

            var deposit = guest * 20;
            var leftMoney = Math.Abs(money - deposit);
            var piratki = 0.0;
            var donation = 0.0;

            if (money >= deposit)
            {
                piratki = Math.Round(leftMoney * 0.4, 0);
                donation = leftMoney - piratki;
                Console.WriteLine($"Yes! {piratki} lv are for fireworks and {donation} lv are for donation.");
            }
            else if (deposit > money) 
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {leftMoney} lv more.");
            }
        }
    }
}
