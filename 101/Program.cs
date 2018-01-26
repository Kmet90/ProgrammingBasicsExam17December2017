using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sand = double.Parse(Console.ReadLine());
            double wood = double.Parse(Console.ReadLine());

            double area = 0.0;

             area = a * b;
            double areaSandBox = (a - (0.2 + 0.2)) * (b - (0.2 + 0.2));
            double areaWoodBox = area - areaSandBox;

            double kgSand = Math.Ceiling(areaSandBox * 20);
            double woodNeed = Math.Ceiling(areaWoodBox / (2.2 * 0.2));

            double priceSand = kgSand * sand;
            double priceWood = woodNeed * wood;

            double sum = priceSand + priceWood;

            Console.WriteLine($"{sum:f2}");

            
        }
    }
}
