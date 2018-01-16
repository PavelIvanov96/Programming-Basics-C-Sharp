using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numCopy = n;

            var number1 = numCopy % 10;
            numCopy = numCopy / 10;
            var number2 = numCopy % 10;
            numCopy = numCopy / 10;
            var number3 = numCopy % 10;





            for (int row = 0; row < number3 + number2; row++)
            {
                for (int cow = 0; cow < number3 + number1; cow++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - number3;
                        Console.Write("{0} ", n);

                    }
                    else if (n % 3 == 0)
                    {
                        n -= number2;

                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 != 0 && n % 5 != 0)
                    {
                        n = n + number1;
                        Console.Write("{0} ", n);

                    }

                }
                Console.WriteLine();
            }
        }
    }
}
