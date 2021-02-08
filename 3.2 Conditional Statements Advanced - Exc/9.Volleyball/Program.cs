using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            double countOfHolidays = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());

            const double weekends = 48;
            double weekendsInSofia = weekends - weekendsInHomeTown;

            double gamesInSofia = weekendsInSofia * 3 / 4;
            double gamesInHomeTown = weekendsInHomeTown;
            double holidaysGames = countOfHolidays * 2 / 3;
            double games = gamesInSofia + gamesInHomeTown + holidaysGames;

            double totalGames = 0;

            switch(leapOrNormal)
            {
                case "normal":
                    totalGames = games;
                    break;
                case "leap":
                    totalGames = games + (games * 0.15);
                    break;
            }
            Console.WriteLine(Math.Floor(totalGames));
                
        }
    }
}
