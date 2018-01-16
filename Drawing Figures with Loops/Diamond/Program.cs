using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;

            for (int i = 0; i < (n - 1) / 2 + 1; i++)
            {



                Console.Write(new string('-', leftRight));
                Console.Write("*");
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', leftRight));

                leftRight--;
                Console.WriteLine();
            }
            leftRight = 1;
            for (int i = 0; i < (n - 1) / 2; i++)
            {

                Console.Write(new string('-', leftRight));
                Console.Write("*");
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', leftRight));

                leftRight++;
                Console.WriteLine();
            }



        }
    }
}
