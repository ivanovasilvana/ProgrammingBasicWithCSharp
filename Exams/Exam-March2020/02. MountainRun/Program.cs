using System;

namespace _02._MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsPerMetre = double.Parse(Console.ReadLine());

            double time = distanceInMetres * timeInSecondsPerMetre + Math.Floor((distanceInMetres / 50)) * 30;

            if (time >= recordInSeconds)
            {
                double diff = time - recordInSeconds;
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }

            else
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
        }
    }
}
