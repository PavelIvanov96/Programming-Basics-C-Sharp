using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОперацииМеждуЧисла_EXAM__26._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string simvol = Console.ReadLine();
            double solution = 0.0;

            if (simvol == "+")
            {
                solution = numberOne + numberTwo;
                if (solution % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numberOne, simvol, numberTwo, solution);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numberOne, simvol, numberTwo, solution);
                }

            }
            else if (simvol == "-")
            {
                solution = numberOne - numberTwo;
                if (solution % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numberOne, simvol, numberTwo, solution);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numberOne, simvol, numberTwo, solution);
                }
            }
            else if (simvol == "*")
            {
                solution = numberOne * numberTwo;
                if (solution % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numberOne, simvol, numberTwo, solution);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numberOne, simvol, numberTwo, solution);
                }
            }
            else if (simvol == "/")
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", numberOne);
                }
                else
                {
                    solution = ((double)numberOne / (double)numberTwo);

                    if (solution % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3:f2}", numberOne, simvol, numberTwo, solution);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3:f2}", numberOne, simvol, numberTwo, solution);
                    }
                }
            }
            else if (simvol == "%")
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", numberOne);
                }
                else
                {
                    solution = numberOne % numberTwo;

                    if (solution % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", numberOne, simvol, numberTwo, solution);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", numberOne, simvol, numberTwo, solution);
                    }
                }
            }



        }
    }
}
