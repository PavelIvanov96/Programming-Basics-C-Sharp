using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_SpecialInteger_24_April_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber < 9; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber < 9; secondNumber++)
                {
                    for (int thrithNumber = 1; thrithNumber < 9; thrithNumber++)
                    {
                        for (int fourthNumber = 1; fourthNumber < 9; fourthNumber++)
                        {
                            if (n % firstNumber == 0 && n % secondNumber == 0 && n % thrithNumber == 0 && n % fourthNumber == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", firstNumber, secondNumber, thrithNumber, fourthNumber);
                            }
                        }
                    }
                }
            }
        }
    }
}
