using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Брадва_28._08._2016
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.Write(new string('-', n * 3));
            Console.Write("**");
            Console.WriteLine(new string('-', n * 2 - 2));
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('-', n * 2 - 2 - i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', n * 3 + 1));
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));
            }

            for (int i = 0; i <= n / 2 - 1; i++)

            {
                if (i != n / 2 - 1)
                {
                    Console.Write(new string('-', n * 3 - i));
                    Console.Write("*");
                    Console.Write(new string('-', n + i * 2 - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n - 1 - i));
                }
                else
                {
                    Console.Write(new string('-', n * 3 - i));
                    Console.Write("*");
                    Console.Write(new string('*', n + i * 2 - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n - 1 - i));
                }

            }



        }
    }
}
