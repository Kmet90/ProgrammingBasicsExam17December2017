using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _505
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n - 4;
            int wing = 2 * n;

            for (int i = 1; i <= n - 2; i++) 
            {
                for (int j = 1; j <= i; j++)            
                {
                    Console.Write("*\\");
                }
               
                Console.Write(new string(' ', width-4));
                width = width - 4;
               
                for (int l = 1; l <= i; l++) 
                {
                    Console.Write("/*");
                }
                Console.WriteLine();                
            }

            width = 4 * n - 4;
            for (int i = 0; i < width / 2; i++) 
            {
                Console.Write("{0}{1}", new string('\\', 1), new string('/', 1));
            }
            Console.WriteLine();

            for (int i = 1; i <= n / 2; i++) 
            {
                Console.WriteLine("{0}*|**|*{1}", new string('<',(width-6) / 2), new string('>', (width - 6) / 2));
            }

            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("{0}{1}", new string('/', 1), new string('\\', 1));
            }
            Console.WriteLine();

            width = 4 ;

            for (int i = n - 2; i >= 1; i--) 
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*/");
                }

                Console.Write(new string(' ', width));
                width = width + 4;

                for (int l = i; l >= 1; l--)
                {
                    Console.Write("\\*");
                }
                Console.WriteLine();
            }

        }
    }
}
