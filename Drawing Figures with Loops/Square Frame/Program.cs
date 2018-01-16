using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            // last line
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
