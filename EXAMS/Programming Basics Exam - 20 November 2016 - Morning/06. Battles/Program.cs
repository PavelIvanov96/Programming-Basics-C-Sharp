using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsFirstPlayer = int.Parse(Console.ReadLine());
            int pokemonsSecondPlayer = int.Parse(Console.ReadLine());
            int maxFights = int.Parse(Console.ReadLine());

            var count = 0;
            for (int firstPokemon = 1; firstPokemon <= pokemonsFirstPlayer; firstPokemon++)
            {
                for (int secondFight = 1; secondFight <= pokemonsSecondPlayer; secondFight++)
                {
                    count++;


                    Console.Write("({0} <-> {1}) ", firstPokemon, secondFight);
                    if (count == maxFights)
                    {
                        return;
                    }


                }
            }
        }
    }
}
