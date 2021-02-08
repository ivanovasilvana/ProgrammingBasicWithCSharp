using System;

namespace _1.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHeritage = double.Parse(Console.ReadLine());
            int yearToLives = int.Parse(Console.ReadLine());
            int age = 17;
            int year = 1800;
            double money = 0;

            for (int i = 1800; i <= yearToLives ; i++)
            {
                year += 1;
                age += 1;
                if (i % 2 == 0)
                {
                    money += 12000;
                }
                else
                {
                    money += 12000 + 50 * age;
                }
            }
             if (moneyHeritage >= money)
             {
                double moneyLeft = moneyHeritage - money;
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
             }
            else
            {
                double moneyNeed = money - moneyHeritage;
                Console.WriteLine($"He will need {moneyNeed:f2} dollars to survive.");
            }
        }
    }
}
