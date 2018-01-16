using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            double disposingDays = double.Parse(Console.ReadLine());
            int personnelOvertime = int.Parse(Console.ReadLine());


            double personnelTraining = disposingDays / 10;
            double hourForWork = (disposingDays - personnelTraining) * 8;
            double hourForWorkPersonnelOvertime = personnelOvertime * (2 * disposingDays);
            double sumHourForWork = Math.Floor(hourForWork + hourForWorkPersonnelOvertime);

            if (sumHourForWork >= neededHours)
            {
                double success = sumHourForWork - neededHours;
                Console.WriteLine("Yes!{0} hours left.", success);
            }
            else
            {
                double notSuccess = neededHours - sumHourForWork;
                Console.WriteLine("Not enough time!{0} hours needed.", notSuccess);
            }

        }
    }
}
