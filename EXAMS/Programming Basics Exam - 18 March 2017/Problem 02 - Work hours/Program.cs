using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHour
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHour = double.Parse(Console.ReadLine());
            double numberOfWorkers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double work = numberOfWorkers * workDays * 8;
            double difference = Math.Abs(neededHour - work);
            double penalties = difference * workDays;
            if (neededHour < work)
            {
                Console.WriteLine("{0} hours left", difference);
            }
            else
            {
                Console.WriteLine("{0} overtime", difference);
                Console.WriteLine("Penalties: {0}", penalties);
            }

        }
    }
}
