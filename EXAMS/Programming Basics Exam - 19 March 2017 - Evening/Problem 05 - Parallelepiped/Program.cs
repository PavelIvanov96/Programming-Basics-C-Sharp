using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.Write("+");
            Console.WriteLine(new string('.', n * 2 + 1));

            for (int i = 0; i <= n * 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', i));
                Console.Write("\\");
                Console.Write(new string('~', n - 2));
                Console.Write("\\");
                Console.WriteLine(new string('.', n * 2 - i));

            }
            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\");
                Console.Write(new string('.', n * 2 - i));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.WriteLine("|");
            }
            Console.Write(new string('.', n * 2 + 1));
            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.WriteLine("+");
        }
    }
}
