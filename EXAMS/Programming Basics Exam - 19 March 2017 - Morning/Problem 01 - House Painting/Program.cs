using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideArea = x * y;
            double windowArea = 1.5 * 1.5;
            double LeftAndRightSides = 2 * sideArea - 2 * windowArea;
            double backSideArea = x * x;
            double entter = 1.2 * 2;
            double sumFaceSideandBackSide = 2 * backSideArea - entter;
            double allSides = LeftAndRightSides + sumFaceSideandBackSide;
            double greenPaint = allSides / 3.4;

            double rectangle = 2 * (x * y);
            double triangle = 2 * (x * h / 2);
            double allAreaOfTop = rectangle + triangle;
            double redPaint = allAreaOfTop / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
