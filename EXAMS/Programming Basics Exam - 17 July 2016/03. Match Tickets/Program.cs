using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string vipOrNormal = Console.ReadLine().ToLower();
            double numberOfPeaopleIntGroup = double.Parse(Console.ReadLine());

            var left = 0.0;
            var numberOfTickets = 0.0;
            var diff = 0.0;

            if (vipOrNormal == "vip")
            {
                if (numberOfPeaopleIntGroup <= 4)
                {
                    left = budget * 0.25;
                }
                else if (numberOfPeaopleIntGroup <= 9)
                {
                    left = budget * 0.40;
                }
                else if (numberOfPeaopleIntGroup <= 24)
                {
                    left = budget * 0.50;
                }
                else if (numberOfPeaopleIntGroup <= 49)
                {
                    left = budget * 0.60;
                }
                else if (numberOfPeaopleIntGroup >= 50)
                {
                    left = budget * 0.75;
                }
                numberOfTickets = numberOfPeaopleIntGroup * 499.99;
                diff = numberOfTickets - left;
                if (diff < 0)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(diff));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(diff));
                }
            }
            else if (vipOrNormal == "normal")
            {
                if (numberOfPeaopleIntGroup <= 4)
                {
                    left = budget * 0.25;
                }
                else if (numberOfPeaopleIntGroup <= 9)
                {
                    left = budget * 0.40;
                }
                else if (numberOfPeaopleIntGroup <= 24)
                {
                    left = budget * 0.50;
                }
                else if (numberOfPeaopleIntGroup <= 49)
                {
                    left = budget * 0.60;
                }
                else if (numberOfPeaopleIntGroup >= 50)
                {
                    left = budget * 0.75;
                }
                numberOfTickets = numberOfPeaopleIntGroup * 249.99;
                diff = numberOfTickets - left;
                if (diff < 0)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(diff));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(diff));
                }
            }
        }
    }
}
