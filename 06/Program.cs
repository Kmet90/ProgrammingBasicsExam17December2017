using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var a = (number / 100) % 10;
            var b = (number / 10) % 10;
            var c = number % 10;

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        if (a> 0 && b>0 && c>0)
                        {
                            var d = i * j * k;
                           Console.WriteLine($"{i} * {j} * {k} = {d};");
                        }
                    }
                }
            }
            
        }
    }
}
