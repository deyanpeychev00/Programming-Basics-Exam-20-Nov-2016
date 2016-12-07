using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1.Рибна_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaSkumriqKg = double.Parse(Console.ReadLine());
            double cenaCacaKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKG = double.Parse(Console.ReadLine());

            double cenaPalamud = cenaSkumriqKg + ((cenaSkumriqKg * 60) / 100);
            double cenaSafrid = cenaCacaKg + ((cenaCacaKg * 80) / 100);
            double cenaMidi = 7.50;

            double finalPalamud = palamudKg * cenaPalamud;
            double finalSafrid = safridKg * cenaSafrid;
            double finalMidi = midiKG * cenaMidi;

            double result = finalMidi + finalPalamud + finalSafrid;

            Console.WriteLine("{0:f2}", result);

        }
    }
}
