using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine();
            string destMetric = Console.ReadLine();

            double baseMetricValue = number;

            if (sourceMetric == "m")
            {
                baseMetricValue = baseMetricValue / 1;
            }
            else if (sourceMetric == "mm")
            {
                baseMetricValue = baseMetricValue / 1000;
            }
            else if (sourceMetric == "cm")
            {
                baseMetricValue = baseMetricValue / 100;
            }
            else if (sourceMetric == "mi")
            {
                baseMetricValue = baseMetricValue / 0.000621371192;
            }
            else if (sourceMetric == "in")
            {
                baseMetricValue = baseMetricValue / 39.3700787;
            }
            else if (sourceMetric == "km")
            {
                baseMetricValue = baseMetricValue / 0.001;
            }
            else if (sourceMetric == "ft")
            {
                baseMetricValue = baseMetricValue / 3.2808399;
            }
            else if (sourceMetric == "yd")
            {
                baseMetricValue = baseMetricValue / 1.0936133;
            }

            if (destMetric == "m")
            {
                baseMetricValue = baseMetricValue * 1;
            }
            else if (destMetric == "mm")
            {
                baseMetricValue = baseMetricValue * 1000;
            }
            else if (destMetric == "cm")
            {
                baseMetricValue = baseMetricValue * 100;
            }
            else if (destMetric == "mi")
            {
                baseMetricValue = baseMetricValue * 0.000621371192;
            }
            else if (destMetric == "in")
            {
                baseMetricValue = baseMetricValue * 39.3700787;
            }
            else if (destMetric == "km")
            {
                baseMetricValue = baseMetricValue * 0.001;
            }
            else if (destMetric == "ft")
            {
                baseMetricValue = baseMetricValue * 3.2808399;
            }
            else if (destMetric == "yd")
            {
                baseMetricValue = baseMetricValue * 1.0936133;
            }
            Console.Write(baseMetricValue);
            Console.WriteLine(" " + destMetric);

        }
    }
}
