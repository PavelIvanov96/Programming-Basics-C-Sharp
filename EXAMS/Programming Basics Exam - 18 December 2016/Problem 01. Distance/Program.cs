using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTimeMinutes = double.Parse(Console.ReadLine());
            double secondTimeMinutes = double.Parse(Console.ReadLine());
            double thirdTimeMinutes = double.Parse(Console.ReadLine());

            double distance = speed * (firstTimeMinutes / 60);
            double afterUp = (speed * 1.10) * (secondTimeMinutes / 60);
            double afterDown = ((speed * 1.10) * 0.95) * (thirdTimeMinutes / 60);
            double sum = distance + afterUp + afterDown;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
