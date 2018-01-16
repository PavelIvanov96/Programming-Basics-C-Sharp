using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTransport = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var sumAvarageBus = 0.0;
            var sumAvarageTire = 0.0;
            var sumAvarageSubway = 0.0;

            for (int i = 0; i < numberOfTransport; i++)
            {
                double tones = double.Parse(Console.ReadLine());
                //tones = sum + tones;
                //sum = tones;

                if (tones <= 3)
                {
                    tones = tones + sumAvarageBus;
                    sumAvarageBus = tones;

                }
                else if (tones <= 11)
                {
                    tones = tones + sumAvarageTire;
                    sumAvarageTire = tones;

                }
                else if (tones >= 12)
                {
                    tones = tones + sumAvarageSubway;
                    sumAvarageSubway = tones;

                }


            }
            sum = sumAvarageBus + sumAvarageSubway + sumAvarageTire;
            double avarage = (sumAvarageBus * 200 + sumAvarageSubway * 120 +
                sumAvarageTire * 175) / sum;
            Console.WriteLine("{0:f2}", avarage);
            Console.WriteLine("{0:f2}%", sumAvarageBus * 100 / sum);
            Console.WriteLine("{0:f2}%", sumAvarageTire * 100 / sum);
            Console.WriteLine("{0:f2}%", sumAvarageSubway * 100 / sum);
        }
    }
}
