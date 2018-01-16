using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double twoSides = a * (a / 2) * 2;
            double square = (a / 2) * (a / 2);
            double triangle = (a / 2 * (b - a / 2)) / 2;
            double behindSide = square + triangle;
            double enter = (a / 5) * (a / 5);

            double frontSide = behindSide - enter;
            double allArea = twoSides + behindSide + frontSide;
            double greenPaint = allArea / 3;

            double redPaint = twoSides / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);


        }
    }
}
