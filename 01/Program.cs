using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double child1 = double.Parse(Console.ReadLine());
            double child2 = double.Parse(Console.ReadLine());
            double child3 = double.Parse(Console.ReadLine());

            var sum = child1 + child2 + child3;
            var leftSum = (money - sum) - ((money - sum) * 0.1);
            Console.WriteLine($"{leftSum:f2}");
        }
    }
}
