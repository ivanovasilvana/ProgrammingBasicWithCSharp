using System;

namespace _2.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();

            double trailJuniors = 5.5;
            double trailSeniors = 7;
            double crossCountryJuniors = 8;
            double crossCountrySeniors = 9.5;
            double downhillJuniors = 12.25;
            double downhillSeniors = 13.75;
            double roadJuniors = 20;
            double roadSeniors = 21.5;

            double moneyJuniors = 0;
            double moneySeniors = 0;

            switch (race)
            {
                case "trail":
                    moneyJuniors = trailJuniors * juniors;
                    moneySeniors = trailSeniors * seniors;
                    break;

                case "cross-country":
                    moneyJuniors = crossCountryJuniors * juniors;
                    moneySeniors = crossCountrySeniors * seniors;
                    if (juniors + seniors >= 50)
                    {
                        moneyJuniors -= 0.25*moneyJuniors;
                        moneySeniors -= 0.25*moneySeniors;
                    }
                    break;

                case "downhill":
                    moneyJuniors = downhillJuniors * juniors;
                    moneySeniors = downhillSeniors * seniors;
                    break;

                case "road":
                    moneyJuniors = roadJuniors * juniors;
                    moneySeniors = roadSeniors * seniors;
                    break;
            }
            double totalMoney = (moneyJuniors + moneySeniors) - (moneyJuniors + moneySeniors) * 0.05;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
