using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
