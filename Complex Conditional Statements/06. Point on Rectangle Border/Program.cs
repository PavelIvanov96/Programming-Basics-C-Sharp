using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // (x >= x2 && x <= x2 && y == y1 ||    //bottom
            //    x >= x1 && x <= x2 && y == y2 ||    //top
            //    x == x1 && y >= y1 && y <= y2 ||     // left
            //    x == x2 && y >= y1 && y <= y2)       // right 

            bool isBottomOrTop = x >= x1 && x <= x2 && (y == y1 || y == y2);

            bool isLeftOrRight = y >= y1 && y < y2 && (x == x1 || x == x2);

            if (isBottomOrTop || isLeftOrRight)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }



        }
    }
}
