using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПоспаливатаКоткаТом
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDay = int.Parse(Console.ReadLine());
            double numberOfRestDay = (365 - restDay);
            double realTimeForGame = (numberOfRestDay * 63 + restDay * 127);
            double differenceNorm = Math.Abs(30000 - realTimeForGame);
            double hour = Math.Floor(differenceNorm / 60);
            double minutes = Math.Round((differenceNorm % 60), 2);

            if (30000 > realTimeForGame)
            {
                Console.WriteLine("Tom sleeps well");
                Console.Write("{0} hours and ", hour);
                Console.WriteLine("{0} minutes less for play", minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.Write("{0} hours and ", hour);
                Console.WriteLine("{0} minutes more for play", minutes);
            }

        }
    }
}
