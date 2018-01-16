using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_MagicNumbers_26_March_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    for (int threthNumber = 1; threthNumber <= 9; threthNumber++)
                    {
                        for (int fourthNumber = 1; fourthNumber <= 9; fourthNumber++)
                        {
                            for (int fifthNumber = 1; fifthNumber <= 9; fifthNumber++)
                            {
                                for (int sixthNumber = 1; sixthNumber <= 9; sixthNumber++)
                                {
                                    if (firstNumber * secondNumber * threthNumber * fourthNumber * fifthNumber * sixthNumber == number)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", firstNumber, secondNumber, threthNumber, fourthNumber, fifthNumber, sixthNumber);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
