using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_StopNumber_17_july_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            var count = m;
            for (int i = m; i >= n; i--)
            {
                if (count % 2 == 0 && count % 3 == 0)

                    Console.Write(count + " ");
                count--;
                if (count % 2 == 0 && count % 3 == 0 && count == s)
                {
                    break;
                }


            }
        }
    }
}
