using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var count = 0;


            for (int fistNumber = startNumber; fistNumber >= endNumber; fistNumber--)
            {

                for (int secondNumber = startNumber; secondNumber >= endNumber; secondNumber--)
                {
                    count++;
                    if (secondNumber + fistNumber == magicNumber)
                    {
                        Console.Write("Combination N:{0} ", count);
                        Console.WriteLine("({0} + {1} = {2})", fistNumber, secondNumber, magicNumber);
                        return;
                    }
                    if (secondNumber + fistNumber != magicNumber)
                    {
                        if (fistNumber == endNumber && secondNumber == endNumber
                            )
                        {
                            Console.Write("{0} ", count);
                            Console.WriteLine("combinations - neither equals {0}", magicNumber);
                        }
                    }
                }
            }
        }
    }
}
