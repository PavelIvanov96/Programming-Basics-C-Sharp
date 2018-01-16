using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var count = 1;
            var count2 = 0;
            var count1 = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write("\\");
                Console.Write(new string('-', 2 * n - count));
                Console.Write("/");
                Console.WriteLine(new string('*', i));
                count += 2;
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n / 2 + i));
                Console.Write("\\");
                Console.Write(new string('*', n - count2));
                Console.Write("/");
                Console.Write(new string('*', n / 2 + i));
                Console.WriteLine("|");
                count2 += 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write("\\");
                Console.Write(new string('*', 2 * n - count1));
                Console.Write("/");
                Console.WriteLine(new string('-', i));
                count1 += 2;
            }
        }
    }
}
