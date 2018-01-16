using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_BackToThePast__17_july_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double beqest = double.Parse(Console.ReadLine());
            int yearForLive = int.Parse(Console.ReadLine());

            var remain = beqest;

            var age = 18;

            for (int i = 1800; i <= yearForLive; i++)

            {


                if (i % 2 == 0)

                {
                    remain = remain - 12000;
                }

                else

                {
                    remain = remain - (12000 + (50 * age));
                }
                age++;
            }

            if (remain >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", remain);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(remain));
            }
        }

    }
}
