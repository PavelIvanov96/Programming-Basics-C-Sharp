using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПоправкаНаПлочки_24._04._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double countryLanding = double.Parse(Console.ReadLine());
            double widthPlate = double.Parse(Console.ReadLine());
            double lengthPlate = double.Parse(Console.ReadLine());
            double widthBench = double.Parse(Console.ReadLine());
            double lengthBench = double.Parse(Console.ReadLine());
            double areaLanding = 0.0, areaBench = 0.0, areaPlate = 0.0, numbersPlate = 0.0, timeToFinish = 0.0;

            areaLanding = countryLanding * countryLanding;
            areaBench = lengthBench * widthBench;
            areaPlate = widthPlate * lengthPlate;
            areaLanding = areaLanding - areaBench;
            numbersPlate = areaLanding / areaPlate;
            timeToFinish = numbersPlate * 0.2;

            Console.WriteLine("{0}", numbersPlate);
            Console.WriteLine("{0}", timeToFinish);

        }
    }
}
