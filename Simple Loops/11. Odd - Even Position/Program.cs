using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minOdd = double.MaxValue, maxOdd = double.MinValue,
                   minEven = double.MaxValue, maxEven = double.MinValue,
                   sumEven = 0, sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (num < minEven)
                    {
                        minEven = num;
                    }
                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                    sumEven += num;
                }
                else
                {
                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }
                    sumOdd += num;
                }
            }

            Console.WriteLine("OddSum={0}", sumOdd);
            if (sumOdd == 0)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", minOdd);
                Console.WriteLine("OddMax={0}", maxOdd);
            }

            Console.WriteLine("EvenSum={0}", sumEven);
            if (sumEven == 0)
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", minEven);
                Console.WriteLine("EvenMax={0}", maxEven);
            }
        }
    }
}
