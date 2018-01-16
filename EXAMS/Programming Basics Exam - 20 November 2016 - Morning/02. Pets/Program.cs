using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDays = double.Parse(Console.ReadLine());
            double leftFoodKg = double.Parse(Console.ReadLine());
            double foodForDayOfDogKg = double.Parse(Console.ReadLine());
            double foodForDayOfCatKg = double.Parse(Console.ReadLine());
            double foodForDayOfThrutleGram = double.Parse(Console.ReadLine());

            double neededFoodForDog = numberOfDays * foodForDayOfDogKg;
            double neededFoodForCat = numberOfDays * foodForDayOfCatKg;
            double neededFoodForThrutle = numberOfDays * foodForDayOfThrutleGram / 1000;
            double sumFood = neededFoodForThrutle + neededFoodForDog + neededFoodForCat;

            double difference = Math.Abs(sumFood - leftFoodKg);
            if (sumFood <= leftFoodKg)

            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(difference));
            }



        }
    }
}
