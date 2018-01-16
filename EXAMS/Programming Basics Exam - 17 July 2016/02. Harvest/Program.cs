using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvast_17_july_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaX = int.Parse(Console.ReadLine());
            double grapeY = double.Parse(Console.ReadLine());
            int litresOfWineZ = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            var allGrape = 0.0;
            var wine = 0.0;
            var winePerPerson = 0.0;
            var wineLeft = 0.0;


            allGrape = areaX * grapeY;
            wine = ((0.4 * allGrape) / (2.5));
            if (wine >= litresOfWineZ)
            {

                wineLeft = Math.Ceiling(wine - litresOfWineZ);
                winePerPerson = Math.Ceiling(wineLeft / numberOfWorkers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wine);
                Console.WriteLine("{0} liters left -> {1} liters per person.", wineLeft, winePerPerson);
            }
            else if (wine <= litresOfWineZ)
            {
                allGrape = areaX * grapeY;
                wine = ((0.4 * allGrape) / (2.5));
                wineLeft = Math.Floor(Math.Abs(litresOfWineZ - wine));
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", wineLeft);
            }


        }
    }
}
