using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        
             private static object perimeter;

        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var area = Math.Abs(x1 - x2) * Math.Abs(y2 - y1);
            var perimeter = 2 * (Math.Abs(x1 - x2) + Math.Abs(y2 - y1));
            Console.WriteLine("area = " + area);
            Console.WriteLine("perimeter = " + perimeter);
        
        }
    }
}
