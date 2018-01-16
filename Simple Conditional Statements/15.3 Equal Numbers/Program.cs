using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 == number2 && number2 == number3)
            {
                Console.WriteLine("yes");
            }
            else if (number1 < number2 || number1 > number2)
            {
                Console.WriteLine("no");
            }
            else if (number2 < number3 || number2 > number3)
            {
                Console.WriteLine("no");
            }
            else if (number1 < number3 || number1 > number3)
            {
                Console.WriteLine("no");
            }
            else if (number1 == number2 || number2 < number3)
            {
                Console.WriteLine("no");
            }
            else if (number1 == number2 || number2 > number3)
            {
                Console.WriteLine("no");
            }
            else if (number2 == number3 || number2 < number3)
            {
                Console.WriteLine("no");
            }
            else if (number2 == number3 || number2 > number3)
            {
                Console.WriteLine("no");
            }
            else if (number1 == number3 || number1 < number3)
            {
                Console.WriteLine("no");
            }
            else if (number1 == number3 || number1 > number3)
            {
                Console.WriteLine("no");
            }

        }
    }
}
