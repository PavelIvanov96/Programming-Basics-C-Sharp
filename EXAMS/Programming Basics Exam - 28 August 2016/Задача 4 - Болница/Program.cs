using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());

            var patientUntreated = 0.0;
            var untreated = 0.0;
            var doctor = 7;
            var treated = 0.0;
            var sum = 0.0;
            for (
                int i = 1; i <= numberOfDays; i++)
            {
                double numberOfPatients = double.Parse(Console.ReadLine());
                if (i % 3 == 0 && sum - patientUntreated < patientUntreated)
                {
                    doctor++;
                }

                if (numberOfPatients > doctor)
                {

                    untreated = patientUntreated + (numberOfPatients - doctor);
                    patientUntreated = untreated;

                }
                numberOfPatients = numberOfPatients + sum;
                sum = numberOfPatients;

            }

            treated = sum - patientUntreated;
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", patientUntreated);
        }
    }
}
