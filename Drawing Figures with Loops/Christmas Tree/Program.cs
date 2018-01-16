using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_КОЛЕДНОДЪРВО_ТЕСТ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //5

            for (int i = 0; i < 1; i++)

            {
                Console.Write(new string(' ', n) + " |");
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i)
                    + new string('*', i) + " | "
                    + new string('*', i));
            }

        }
    }
}
