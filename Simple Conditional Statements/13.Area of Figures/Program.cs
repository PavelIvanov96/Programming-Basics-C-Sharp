using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string square;
            string rectangle;
            string circle;
            string triangle;
            double area;

            string input = Console.ReadLine();
            if (input == "square")
            {
                double SideA = double.Parse(Console.ReadLine());
                area = SideA * SideA;
                Console.WriteLine("{0}", area);
            }
            if (input == "rectangle")
            {
                double SideA = double.Parse(Console.ReadLine());
                double SideB = double.Parse(Console.ReadLine());
                area = SideA * SideB;
                Console.WriteLine("{0}", area);
            }
            if (input == "circle")
            {
                double Radius = double.Parse(Console.ReadLine());
                area = Math.PI * Radius * Radius;
                Console.WriteLine("{0}", area);
            }
            if (input == "triangle")
            {
                double SideA = double.Parse(Console.ReadLine());
                double Height = double.Parse(Console.ReadLine());
                area = (SideA * Height) / 2;
                Console.WriteLine("{0}", area);
            }

        }

    }
}

