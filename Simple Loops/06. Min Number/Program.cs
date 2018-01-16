using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumber = int.Parse(Console.ReadLine());
            var minimalNumber = double.MaxValue;

            for (int i = 0; i < numberOfNumber; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < minimalNumber)
                {
                    minimalNumber = currentNumber;
                }
            }
            Console.WriteLine(minimalNumber);


        }
    }
}
