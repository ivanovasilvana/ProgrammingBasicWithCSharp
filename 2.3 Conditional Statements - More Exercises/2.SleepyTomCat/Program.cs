using System;

namespace _2.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int minutesWorkdays = 63;
            int minutesHolidays = 127;
            int workDays = 365 - holidays;
            int minutesForPlay = holidays * minutesHolidays + workDays * minutesWorkdays;
            if (minutesForPlay <= 30000)
            {
                int minutesLeft = 30000 - minutesForPlay;
                int hours = minutesLeft / 60;
                int minutes = minutesLeft - (hours * 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                int minutesLeft = minutesForPlay - 30000;
                int hours = minutesLeft / 60;
                int minutes = minutesLeft - (hours * 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
