using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var sumCar = 0.0;
            var sumSmallBus = 0.0;
            var sumBigBus = 0.0;
            var sumTrain = 0.0;
            var sumMiniBus = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                double numberOfPeaople = double.Parse(Console.ReadLine());

                if (numberOfPeaople <= 5)
                {
                    numberOfPeaople = numberOfPeaople + sumCar;
                    sumCar = numberOfPeaople;
                }
                else if (numberOfPeaople <= 12)
                {
                    numberOfPeaople = numberOfPeaople + sumMiniBus;
                    sumMiniBus = numberOfPeaople;
                }
                else if (numberOfPeaople <= 25)
                {
                    numberOfPeaople = numberOfPeaople + sumSmallBus;
                    sumSmallBus = numberOfPeaople;
                }
                else if (numberOfPeaople <= 40)
                {
                    numberOfPeaople = numberOfPeaople + sumBigBus;
                    sumBigBus = numberOfPeaople;
                }
                else if (numberOfPeaople >= 41)
                {
                    numberOfPeaople = numberOfPeaople + sumTrain;
                    sumTrain = numberOfPeaople;
                }


            }

            sum = sumBigBus + sumCar + sumSmallBus + sumTrain + sumMiniBus;
            var procentCar = sumCar / sum * 100;
            var procentSmallBus = sumSmallBus / sum * 100;
            var procentBigBus = sumBigBus / sum * 100;
            var procentTrain = sumTrain / sum * 100;
            var procentMiniBus = sumMiniBus / sum * 100;



            Console.WriteLine("{0:f2}%", procentCar);
            Console.WriteLine("{0:f2}%", procentMiniBus);
            Console.WriteLine("{0:f2}%", procentSmallBus);
            Console.WriteLine("{0:f2}%", procentBigBus);
            Console.WriteLine("{0:f2}%", procentTrain);

        }
    }
}
