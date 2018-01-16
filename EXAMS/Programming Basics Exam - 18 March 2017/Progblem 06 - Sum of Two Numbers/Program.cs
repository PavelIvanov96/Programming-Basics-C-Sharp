using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            double endNumber = int.Parse(Console.ReadLine());
            double magicNumber = double.Parse(Console.ReadLine());

            var count = 1;

            for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {


                    if (firstNumber + secondNumber == magicNumber)
                    {

                        Console.Write("Combination N:{0} ", count);
                        Console.WriteLine("({0} + {1} = {2})", firstNumber, secondNumber, magicNumber);
                        return;
                    }
                    if (firstNumber == endNumber && secondNumber == endNumber)
                    {
                        Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
                    }

                    count++;
                }

            }
        }
    }
}
