using System;

namespace _07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double distanceInSecond = distance * timeInSeconds;
            double delay = Math.Floor(distance / 15) * 12.5;
            double finaleTime = distanceInSecond + delay;

            if (finaleTime<record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finaleTime:f2} seconds.");
            }
            else if (finaleTime>=record)
            {
                double secondsNeed = finaleTime - record;
                Console.WriteLine($"No, he failed! He was {secondsNeed:f2} seconds slower.");
            }
        }
    }
}
