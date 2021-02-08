using System;

namespace _06._TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int winGames = 0;
            int loseGames = 0;
            int winGameForDay = 0;
            int loseGameForDay = 0;
            double sum = 0;
            double finaleSum = 0;
            string result = "";

            for (int i = 1; i <= days; i++)
            {
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    result = Console.ReadLine();

                    if (result == "Finish")
                    {
                        break;
                    }
                    if (result == "win")
                    {
                        winGameForDay++;
                        sum += 20;
                    }

                    else if (result == "lose")
                    {
                        loseGameForDay++;
                        sum += 0;
                    }

                    if (winGameForDay > loseGameForDay)
                    {
                        sum += sum * 0.1;
                    }
                    else
                    {
                        sum += 0;
                    }

                    winGames += winGameForDay;
                    loseGames += loseGameForDay;
                    finaleSum += sum;
                    sum = 0;
                    sport = Console.ReadLine();
                }
                    winGameForDay = 0;
                    loseGameForDay = 0;
            }

            if (winGames > loseGames)
            {
                finaleSum += finaleSum * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {finaleSum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {finaleSum:f2}");
            }
        }
    }
}
