using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LectorsSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());


            var sumJelev = 0.0;
            var sumRoyal = 0.0;
            var sumRoli = 0.0;
            var sumTrofon = 0.0;
            var sumSino = 0.0;
            var sumOthers = 0.0;

            double differense = (double)budget / lections;

            for (int i = 1; i <= lections; i++)
            {
                string lectors = Console.ReadLine().ToLower();
                if (lectors == "jelev")
                {
                    sumJelev++;
                }
                if (lectors == "royal")
                {
                    sumRoyal++;
                }
                if (lectors == "roli")
                {
                    sumRoli++;
                }
                if (lectors == "trofon")
                {
                    sumTrofon++;

                }
                if (lectors == "sino")
                {
                    sumSino++;

                }
                else if (lectors != "jelev" && lectors != "royal" && lectors != "roli" && lectors != "trofon" && lectors != "sino")
                {
                    sumOthers++;
                }
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", sumJelev * differense);
            Console.WriteLine("RoYaL salary: {0:f2} lv", sumRoyal * differense);
            Console.WriteLine("Roli salary: {0:f2} lv", sumRoli * differense);
            Console.WriteLine("Trofon salary: {0:f2} lv", sumTrofon * differense);
            Console.WriteLine("Sino salary: {0:f2} lv", sumSino * differense);
            Console.WriteLine("Others salary: {0:f2} lv", sumOthers * differense);
        }
    }
}
