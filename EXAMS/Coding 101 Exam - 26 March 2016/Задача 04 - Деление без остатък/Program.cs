using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Деление_без_остатък_26_March_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double integerOf2 = 0;
            double integerOf3 = 0;
            double integerOf4 = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    ++integerOf2;
                }
                if (number % 3 == 0)
                {
                    ++integerOf3;
                }
                if (number % 4 == 0)
                {
                    ++integerOf4;
                }
            }


            Console.WriteLine("{0:f2}%", integerOf2 / n * 100);
            Console.WriteLine("{0:f2}%", integerOf3 / n * 100);
            Console.WriteLine("{0:f2}%", integerOf4 / n * 100);
        }
    }
}
