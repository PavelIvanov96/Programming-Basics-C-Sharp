using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dashes = (3 * n - 2) / 2;
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dashes - i));
                Console.Write("/");
                Console.Write(new string(' ', 2 * i));
                Console.Write("\\");
                Console.WriteLine(new string('.', dashes - i));
            }

            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n * 2));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', n * 2 - 2));
                Console.Write("|");
                Console.WriteLine(new string('.', n / 2));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n / 2 - i));
                Console.Write("/");
                Console.Write(new string('*', n * 2 - 2 + count));
                Console.Write("\\");
                Console.WriteLine(new string('.', n / 2 - i));
                count += 2;
            }
        }
    }
}
