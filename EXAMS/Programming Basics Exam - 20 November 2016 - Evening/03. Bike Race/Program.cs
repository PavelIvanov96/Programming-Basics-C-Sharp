using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string map = Console.ReadLine().ToLower();

            var sum = 0.0;

            if (map == "trail")
            {
                sum = (junior * 5.50 + senior * 7) * 0.95;
                Console.WriteLine("{0:f2}", sum);
            }
            else if (map == "cross-country")
            {

                if (junior + senior >= 50)
                {
                    sum = (junior * 8 + senior * 9.50) * 0.75;
                    Console.WriteLine("{0:f2}", sum * 0.95);
                }
                else
                {
                    sum = (junior * 8 + senior * 9.50) * 0.95;
                    Console.WriteLine("{0:f2}", sum);
                }

            }
            else if (map == "downhill")
            {
                sum = (junior * 12.25 + senior * 13.75) * 0.95;
                Console.WriteLine("{0:f2}", sum);
            }
            else if (map == "road")
            {
                sum = (junior * 20 + senior * 21.50) * 0.95;
                Console.WriteLine("{0:f2}", sum);
            }



        }
    }
}
