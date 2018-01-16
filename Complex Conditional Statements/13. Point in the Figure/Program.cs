using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= 0 && x <= 3 * h) && (y >= 0 && y <= h))
            {
                if (
                    (
                    (x == 0 || x == 3 * h) && (y >= 0 && y <= h)  // vertical 
                    )
                    ||
                    (x >= 0 && x <= 3 * h && y == 0) ||
                    (y == h && ((x >= 0 && x <= h) || (x >= 2 * h && x <= 3 * h))) //horizontal

                    )
                {
                    Console.WriteLine("border");
                }
                else
                {
                    Console.WriteLine("inside");
                }
            }
            else if ((x >= h && x <= 2 * h) && (y >= h && y <= 4 * h))
            {
                if (
                    (x >= h && x <= 2 * h && y == 4 * h) // horizontal
                    ||
                    ((x == h || x == 2 * h) && (y >= h && y <= 4 * h))// verticals
                    )

                {
                    Console.WriteLine("border");
                }
                else
                {
                    Console.WriteLine("inside");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }

        }


    }
}

