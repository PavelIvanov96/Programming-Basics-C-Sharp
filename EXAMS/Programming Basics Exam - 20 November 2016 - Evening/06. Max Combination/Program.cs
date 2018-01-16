using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());

            var count = 1;
            for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {

                    if (count <= maxCombinations)
                    {
                        Console.Write("<{0}-{1}>", firstNumber, secondNumber);

                    }
                    count++;
                }
            }
        }
    }
}
