using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (number <= 100) bonusPoints = 5;
            else if (number <= 1000) bonusPoints = 0.2 * number;
            else bonusPoints = 0.1 * number;
            if (number % 2 == 0) bonusPoints += 1;
            if (number % 10 == 5) bonusPoints += 2;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + number);

        }
    }
}
