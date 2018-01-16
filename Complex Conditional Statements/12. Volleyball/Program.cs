using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int fests = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            int weekendsSofia = 48 - weekends;
            double playsInSofia = weekendsSofia * 3.0 / 4;
            double playsWhenFests = fests * 2.0 / 3;

            double totalPlays = playsInSofia + playsWhenFests + weekends;
            if (year == "leap")
            {
                totalPlays += totalPlays * 15 / 100;
            }

            double result = Math.Truncate(totalPlays);

            Console.WriteLine(result);
        }
    }
}
