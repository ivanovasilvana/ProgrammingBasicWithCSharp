using System;

namespace _02._LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            int timeOfMovie = int.Parse(Console.ReadLine());
            int timeOfRest = int.Parse(Console.ReadLine());

            double timeForLunch = 1.0 * timeOfRest * 1 / 8;
            double timeForMovie = 1.0 * timeOfRest * 1 / 4;
            double timeLeft = 1.0* timeOfRest - 1.0 *timeForLunch - 1.0 * timeForMovie;

            if (timeLeft >= timeOfMovie)
            {
                double diff = timeLeft - timeOfMovie;
                Console.WriteLine($"You have enough time to watch {nameOfMovie} and left with {Math.Ceiling(diff)} minutes free time.");
            }

            else
            {
                double timeNeeded = timeOfMovie - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {nameOfMovie}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}
