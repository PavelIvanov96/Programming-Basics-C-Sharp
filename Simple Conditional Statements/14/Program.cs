using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIme__15_min
{
    class Program
    {


        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes > 59)
            {
                hour++;
                minutes = minutes - 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }

            string minutesStr = minutes.ToString();
            minutesStr = minutesStr.PadLeft(2, '0');

            Console.WriteLine(hour + ":" + minutesStr);



        }
    }
}
