using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            if (pass == "qwerty")
            {
                Console.WriteLine("Wrong password!");
            }
            else if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (pass == "s3cr3t!p@ss")
            {
                Console.WriteLine("Wrong password!");
            }


        }
    }
}
