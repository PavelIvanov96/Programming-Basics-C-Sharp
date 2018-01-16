using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', (4 * n) / 2 - 1));
            Console.Write("/");
            Console.Write("|");
            Console.Write("\\");
            Console.WriteLine(new string('.', (4 * n) / 2 - 1));

            Console.Write(new string('.', (4 * n) / 2 - 1));
            Console.Write("\\");
            Console.Write("|");
            Console.Write("/");
            Console.WriteLine(new string('.', (4 * n) / 2 - 1));
            Console.Write(new string('.', (4 * n) / 2 - 1));
            Console.Write("***");
            Console.WriteLine(new string('.', (4 * n) / 2 - 1));

            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write(new string('.', (4 * n) / 2 - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('.', (4 * n) / 2 - 1 - i));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < (4 * n + 1) / 2; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
