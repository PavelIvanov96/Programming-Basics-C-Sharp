using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numberOfUnderscores = ((4 * n + 3) - 9) / 2;

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', (n * 2) + 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();
            for (int i = 0; i < n; i++)

            {
                Console.Write(new string('.', n - i));
                Console.Write(new string('/', 1) + "/");
                Console.Write(new string('_', ((n * 2) - 1) + 2 * i));
                Console.Write(@"\");
                Console.Write(@"\");
                Console.Write(new string('.', n - i));




                Console.WriteLine();
            }
            Console.Write("//");
            Console.Write(new string('_', numberOfUnderscores));
            Console.Write("STOP!");
            Console.Write(new string('_', numberOfUnderscores));
            Console.WriteLine(@"\\");
            for (int i = n; i > 0; i--)
            {
                Console.Write(new string('.', n - i));
                Console.Write(@"\\");
                Console.Write(new string('_', ((n * 2) - 1) + 2 * i));
                Console.Write("//");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
        }
    }
}
