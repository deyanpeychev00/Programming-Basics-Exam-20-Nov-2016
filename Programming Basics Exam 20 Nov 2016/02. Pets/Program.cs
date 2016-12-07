using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2.Домашни_любимци
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysNum = int.Parse(Console.ReadLine());
            var hranaKg = double.Parse(Console.ReadLine());
            var KGdogFoodPerDay = double.Parse(Console.ReadLine());
            var KGcatFoodPerDay = double.Parse(Console.ReadLine());
            var GRturtleFoodPerDay = double.Parse(Console.ReadLine());

            var neededFoodDog = daysNum * KGdogFoodPerDay;
            var neededFoodCat = daysNum * KGcatFoodPerDay;
            var neededFoodTurtle = (daysNum * GRturtleFoodPerDay) / 1000;

            var finalFood = neededFoodCat + neededFoodDog + neededFoodTurtle;

            var result = 0.0;
            if (finalFood <= hranaKg)
            {
                result = hranaKg - finalFood;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(result));
            }
            else
            {
                result = finalFood - hranaKg;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(result));
            }
        }
    }
}
