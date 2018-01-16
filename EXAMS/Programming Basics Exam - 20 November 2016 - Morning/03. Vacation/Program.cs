using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOldPerson = int.Parse(Console.ReadLine());
            int numberOfStudies = int.Parse(Console.ReadLine());
            int numberOfNight = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();

            var oldPerson = 0.0;
            var studies = 0.0;
            var sumTransport = 0.0;
            var hotel = 0.0;
            var comission = 0.0;
            var allSum = 0.0;

            if (transport == "train")
            {
                if (numberOfOldPerson + numberOfStudies >= 50)
                {
                    oldPerson = numberOfOldPerson * 24.99;
                    studies = numberOfStudies * 14.99;
                    sumTransport = (oldPerson + studies);
                    hotel = numberOfNight * 82.99;
                    comission = (sumTransport + hotel) * 0.10;
                    allSum = comission + hotel + sumTransport;
                    Console.WriteLine("{0:f2}", allSum);
                }
                else
                {
                    oldPerson = numberOfOldPerson * 24.99;
                    studies = numberOfStudies * 14.99;
                    sumTransport = (oldPerson + studies) * 2;
                    hotel = numberOfNight * 82.99;
                    comission = (sumTransport + hotel) * 0.10;
                    allSum = comission + hotel + sumTransport;
                    Console.WriteLine("{0:f2}", allSum);
                }
            }
            else if (transport == "bus")
            {
                oldPerson = numberOfOldPerson * 32.50;
                studies = numberOfStudies * 28.50;
                sumTransport = (oldPerson + studies) * 2;
                hotel = numberOfNight * 82.99;
                comission = (sumTransport + hotel) * 0.10;
                allSum = comission + hotel + sumTransport;
                Console.WriteLine("{0:f2}", allSum);
            }
            else if (transport == "boat")
            {
                oldPerson = numberOfOldPerson * 42.99;
                studies = numberOfStudies * 39.99;
                sumTransport = (oldPerson + studies) * 2;
                hotel = numberOfNight * 82.99;
                comission = (sumTransport + hotel) * 0.10;
                allSum = comission + hotel + sumTransport;
                Console.WriteLine("{0:f2}", allSum);
            }
            else if (transport == "airplane")
            {
                oldPerson = numberOfOldPerson * 70;
                studies = numberOfStudies * 50;
                sumTransport = (oldPerson + studies) * 2;
                hotel = numberOfNight * 82.99;
                comission = (sumTransport + hotel) * 0.10;
                allSum = comission + hotel + sumTransport;
                Console.WriteLine("{0:f2}", allSum);

            }
        }
    }
}
