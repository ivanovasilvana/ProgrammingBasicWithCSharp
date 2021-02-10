using System;

namespace _6CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четe 1 ред:
            //•	Наем за залата – реално число в интервала[100.00..10000.00]
            double rentForHall = double.Parse(Console.ReadLine());
            //Торта  – цената ѝ е 20 % от наема на залата
            double priseForCaке = rentForHall * 0.20;
            //•	Напитки – цената им е 45 % по - малко от тази на тортата
            double priseForDrinks = priseForCaке - (priseForCaке * 0.45);
            //•	Аниматор – цената му е 1 / 3 от цената за наема на залата
            double animatorPrice = rentForHall / 3; 
            //Да се отпечата на конзолата какъв бюджет ще бъде необходим за организиране на тържеството.
            double finalePriceForParty = rentForHall + priseForCaке + priseForDrinks + animatorPrice;
            Console.WriteLine(finalePriceForParty);

        }
    }
}
