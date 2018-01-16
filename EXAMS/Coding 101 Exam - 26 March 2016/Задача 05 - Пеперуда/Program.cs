using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.Write(new string('*', n - 2));
                Console.Write(@"\");
                Console.Write(" ");
                Console.Write("/");
                Console.Write(new string('*', n - 2));
                Console.WriteLine();
                Console.Write(new string('-', n - 2));
                Console.Write(@"\");
                Console.Write(" ");
                Console.Write("/");
                Console.Write(new string('-', n - 2));
                Console.WriteLine();
            }

            Console.Write(new string('*', n - 2));
            Console.Write(@"\");
            Console.Write(" ");
            Console.Write("/");
            Console.Write(new string('*', n - 2));
            Console.WriteLine();
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("@");
            Console.Write(new string('*', n - 2));
            Console.Write("/");
            Console.Write(" ");
            Console.Write(@"\");
            Console.Write(new string('*', n - 2));
            Console.WriteLine();

            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.Write(new string('-', n - 2));
                Console.Write("/");
                Console.Write(" ");
                Console.Write(@"\");
                Console.Write(new string('-', n - 2));
                Console.WriteLine();
                Console.Write(new string('*', n - 2));
                Console.Write("/");
                Console.Write(" ");
                Console.Write(@"\");
                Console.Write(new string('*', n - 2));
                Console.WriteLine();
            }

        }
    }
}
