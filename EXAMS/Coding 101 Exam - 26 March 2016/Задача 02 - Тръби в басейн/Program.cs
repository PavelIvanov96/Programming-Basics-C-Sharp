using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool_26.March._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeV = int.Parse(Console.ReadLine());
            int flowFirstPipe = int.Parse(Console.ReadLine());
            int flowSecondPipe = int.Parse(Console.ReadLine());
            double hourLeave = double.Parse(Console.ReadLine());

            var fillingThePoolFirstPipe = flowFirstPipe * hourLeave;
            var fillingThePoolSecondPipe = flowSecondPipe * hourLeave;
            var fillingThePool = fillingThePoolFirstPipe + fillingThePoolSecondPipe;
            if (fillingThePool <= sizeV)
            {
                var rateFillingThePool = Math.Floor(fillingThePool / sizeV * 100);
                var rateFirstPipe = Math.Floor(fillingThePoolFirstPipe / fillingThePool * 100);
                var rateSecondPipe = Math.Floor(fillingThePoolSecondPipe / fillingThePool * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", rateFillingThePool, rateFirstPipe, rateSecondPipe);
            }
            else
            {
                var overFlowing = fillingThePool - sizeV;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hourLeave, overFlowing);
            }
        }
    }
}
