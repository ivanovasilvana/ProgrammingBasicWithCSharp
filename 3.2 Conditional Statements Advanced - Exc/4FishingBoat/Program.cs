using System;

namespace _4FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double springRent = 3000;
            const double summerAndAutumnRent = 4200;
            const double winterRent = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisher = int.Parse(Console.ReadLine());
            double totalMoney = 0;

            switch (season)
            {
                case "Spring":
                    totalMoney = springRent;
                    break;
                case "Summer":
                case "Autumn":
                    totalMoney = summerAndAutumnRent;
                    break;
                case "Winter":
                    totalMoney = winterRent;
                    break;
            }
            if (fisher <= 6)
            {
                totalMoney -= totalMoney * 0.1;
            }
            else if (fisher >= 7 && fisher <= 11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else if (fisher >= 12)
            {
                totalMoney -= totalMoney * 0.25;
            }
            if(fisher%2==0&&season!="Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }
            if (budget>=totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget<totalMoney)
            {
                double moneyNeed = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
