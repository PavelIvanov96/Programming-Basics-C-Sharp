using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПясъченЧасовинк_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', 2 * n + 1));

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string(' ', n * 2 - 3));
            Console.Write("*");
            Console.WriteLine(".");

            var dashes = 2;
            var simvol = n * 2 - 5;

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', dashes));
                Console.Write("*");
                Console.Write(new string('@', simvol));
                Console.Write("*");
                Console.WriteLine(new string('.', dashes));

                dashes += 1;
                simvol -= 2;
            }
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));

            dashes = n - 1;

            for (int i = 0; i <= n - 2; i++)
            {
                if (i != n - 2)
                {
                    Console.Write(new string('.', dashes));
                    Console.Write("*");
                    Console.Write(new string(' ', i));
                    Console.Write("@");
                    Console.Write(new string(' ', i));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dashes));
                }
                else
                {
                    Console.Write(new string('.', dashes));
                    Console.Write("*");
                    Console.Write(new string('@', i));
                    Console.Write("@");
                    Console.Write(new string('@', i));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dashes));
                }

                dashes -= 1;

            }

            Console.WriteLine(new string('*', 2 * n + 1));

        }
    }
}
