using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAMOND_17_july_2016_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var point = n * 3;

            Console.Write(new string('.', n));
            Console.Write(new string('*', point));
            Console.WriteLine(new string('.', n));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("*");
                Console.Write(new string('.', point));
                Console.Write("*");
                Console.WriteLine(new string('.', n - i));
                point += 2;
            }

            Console.WriteLine(new string('*', n * 5));

            for (int i = 1; i <= 2 * n; i++)
            {
                point -= 2;
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', point));
                Console.Write("*");
                Console.WriteLine(new string('.', i));
                if (i == 2 * n)
                {
                    Console.Write(new string('.', n * 2 + 1));
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine(new string('.', n * 2 + 1));
                }


            }


        }
    }
}
