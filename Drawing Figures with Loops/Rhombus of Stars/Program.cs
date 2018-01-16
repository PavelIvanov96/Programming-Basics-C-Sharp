using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part
            for (int i = 0; i < n; i++) // n = 3 
            {
                Console.Write(new string(' ', n - 1 - i) + "*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            // Lower part 
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', i + 1) + "*");
                for (int k = 0; k < n - 2 - i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
