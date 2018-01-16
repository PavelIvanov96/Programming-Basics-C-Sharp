using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            var count1 = 0;
            var sum = 0.0;

            var count2 = 0;
            var count3 = 0;
            var count4 = 0;
            var count5 = 0;
            var count6 = 0;


            for (int i = 0; i < number; i++)
            {
                double entry = double.Parse(Console.ReadLine());


                if (entry <= 9 && entry >= 0)
                {
                    sum = sum + entry * 0.2;

                    count1++;
                }
                else if (entry <= 19 && entry >= 10)
                {
                    sum = sum + entry * 0.3;

                    count2++;
                }
                else if (entry <= 29 && entry >= 20)
                {
                    sum = sum + entry * 0.40;

                    count3++;
                }

                else if (entry <= 39 && entry >= 30)
                {
                    sum = sum + 50;

                    count4++;
                }
                else if (entry <= 50 && entry >= 40)
                {
                    sum = sum + 100;

                    count5++;
                }
                else if (entry < 0 || entry > 50)
                {
                    sum = sum / 2;

                    count6++;
                }


            }

            Console.WriteLine("{0:f2}", sum);
            Console.WriteLine("From 0 to 9: {0:F2}%", count1 / number * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", count2 / number * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", count3 / number * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", count4 / number * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", count5 / number * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", count6 / number * 100);
        }
    }
}
