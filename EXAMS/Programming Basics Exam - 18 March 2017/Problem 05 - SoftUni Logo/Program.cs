using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var count = 1;
            var countBottom = 0;
            var dies = 6;

            for (int i = 1; i < n * 2; i++)
            {
                Console.Write(new string('.', (12 * n - 5 - count) / 2));
                Console.Write(new string('#', count));
                Console.WriteLine(new string('.', ((12 * n - 5 - count) / 2)));


                count += 6;
            }
            Console.WriteLine(new string('#', 12 * n - 5));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', 2 + countBottom));
                Console.Write(new string('#', 12 * n - 5 - dies));
                Console.WriteLine(new string('.', 3 + countBottom));

                countBottom += 3;
                dies += 6;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                { Console.Write("@"); }
                else
                { Console.Write("|"); }
                Console.Write(new string('.', 2 + countBottom));
                Console.Write(new string('#', (12 * n - 5) - 2 * (3 + countBottom)));
                Console.WriteLine(new string('.', 3 + countBottom));

            }
        }
    }
}
