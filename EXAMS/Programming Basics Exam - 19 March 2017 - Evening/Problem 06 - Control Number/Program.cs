using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var count = 0;


            for (int firstNumber = 1; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = m; secondNumber >= 1; secondNumber--)
                {
                    count++;

                    sum = sum + firstNumber * 2 + secondNumber * 3;

                    if (sum >= controlNumber)
                    {
                        Console.WriteLine("{0} moves", count);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
                        return;
                    }
                }

            }

            Console.WriteLine("{0} moves", count);
        }
    }
}

