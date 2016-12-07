using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6.Битки
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerPokemons = int.Parse(Console.ReadLine());
            var secondPlayerPokemons = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= firstPlayerPokemons; i++)
            {
                for (int j = 1; j <= secondPlayerPokemons; j++)
                {

                    Console.Write("({0} <-> {1}) ", i, j);
                    counter++;
                    if (counter == maxBattles)
                    {
                        break;
                    }
                }
                if (counter == maxBattles)
                {
                    break;
                }
            }
        }
    }
}
