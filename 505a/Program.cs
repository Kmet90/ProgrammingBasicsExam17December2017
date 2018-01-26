using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _505a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n - 4;
            string a = "*\\";
            string b = "/*";


            for (int i = 0; i < n - 2; i++) 
            {
                Console.WriteLine("{0}{1}{2}", a, new string('&', width-4), b);
                a = a + "*\\";
                b = b + "/*";
                width = width - 4;        
            }

            width = 4 * n - 4;
            for (int i = 0; i < width / 2 + 1; i++) 
            {
                Console.Write("{0}{1}", new string('\\', 1), new string('/', 1));
            }
            Console.WriteLine("\\/");

            for (int i = 0; i < width / 2 + 1; i++)
            {
                Console.Write("{0}{1}", new string('\\', 1), new string('/', 1));
            }
            Console.WriteLine("\\/");

            for (int i = n-2; i >0; i--)
            {
                string c1 = "*\\";
                Console.WriteLine("{0}{1}{2}", a, new string('&', width), b);
                
                b = b + "/*";
                width = width + 4;
            }
        }
    }
}
