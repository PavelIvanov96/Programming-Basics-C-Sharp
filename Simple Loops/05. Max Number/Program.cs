using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            var greatestNumber = double.MinValue;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber > greatestNumber)
                {
                    greatestNumber = currentNumber;
                }

            }
            Console.WriteLine(greatestNumber);

        }
    }
}
