using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int zymbull = int.Parse(Console.ReadLine());
            int rouse = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double sum = (magnolia * 3.25 + zymbull * 4 + rouse * 3.50 + cactus * 8) * 0.95;

            double difference = Math.Abs(sum - priceGift);
            if (sum < priceGift)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(difference));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(difference));
            }

        }
    }
}
