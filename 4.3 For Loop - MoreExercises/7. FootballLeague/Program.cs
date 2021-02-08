using System;

namespace _7._FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            const double convert = 1.0;
            int capacity = int.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());
            int fensA = 0;
            int fensB = 0;
            int fensV = 0;
            int fensG =0;
            for (int i = 1; i <= fens; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    fensA++;
                }
                else if (sector == "B")
                {
                    fensB++;
                }
                else if (sector == "V" )
                {
                    fensV++;
                }
                else if (sector == "G")
                {
                    fensG++;
                }
            }

            double procentFansInSectorA = ((convert *fensA) / fens) * 100;
            double procentFansInSectorB = ((convert * fensB) / fens) * 100;
            double procentFansInSectorV = ((convert *fensV) / fens) * 100;
            double procentFansInSectorG = (convert * fensG / fens) * 100;
            double procentFans = ((convert * fens) / capacity) * 100;

            Console.WriteLine($"{procentFansInSectorA:f2}%");
            Console.WriteLine($"{procentFansInSectorB:f2}%");
            Console.WriteLine($"{procentFansInSectorV:f2}%");
            Console.WriteLine($"{procentFansInSectorG:f2}%");
            Console.WriteLine($"{procentFans:f2}%");
        }
    }
}
