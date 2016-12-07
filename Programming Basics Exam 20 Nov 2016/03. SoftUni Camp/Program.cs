using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4.СофтУни_Кемп
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupsNum = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var counterCar = 0.0;
            var counterMicrobus = 0.0;
            var counterBus = 0.0;
            var counterAutobus = 0.0;
            var counterTrain = 0.0;

            for (int i = 0; i < groupsNum; i++)
            {
                var peoplePerGroup = int.Parse(Console.ReadLine());
                sum += peoplePerGroup;
                if (peoplePerGroup <= 5)
                {
                    counterCar += peoplePerGroup;
                }
                else if (peoplePerGroup >= 6 && peoplePerGroup <= 12)
                {
                    counterMicrobus += peoplePerGroup;
                }
                else if (peoplePerGroup >= 13 && peoplePerGroup <= 25)
                {
                    counterBus += peoplePerGroup;
                }
                else if (peoplePerGroup >= 26 && peoplePerGroup <= 40)
                {
                    counterAutobus += peoplePerGroup;
                }
                else if (peoplePerGroup >= 41)
                {
                    counterTrain += peoplePerGroup;
                }
            }
            //Console.WriteLine("--------------------------------------");
            //    Console.WriteLine(counterCar);
            //    Console.WriteLine(counterMicrobus);
            //    Console.WriteLine(counterBus);
            //    Console.WriteLine(counterAutobus);
            //    Console.WriteLine(counterTrain);
            //Console.WriteLine("--------------------------------------");
            //    Console.WriteLine(sum);
            //Console.WriteLine("--------------------------------------");

            double carPercentage = (double)(counterCar / sum) * 100;
            double microbusPercentage = (double)(counterMicrobus / sum) * 100;
            double busPercentage = (double)(counterBus / sum) * 100;
            double autobusPercentage = (double)(counterAutobus / sum) * 100;
            double trainPercentage = (double)(counterTrain / sum) * 100;

            Console.WriteLine("{0:f2}%", carPercentage);
            Console.WriteLine("{0:f2}%", microbusPercentage);
            Console.WriteLine("{0:f2}%", busPercentage);
            Console.WriteLine("{0:f2}%", autobusPercentage);
            Console.WriteLine("{0:f2}%", trainPercentage);
        }
    }
}
