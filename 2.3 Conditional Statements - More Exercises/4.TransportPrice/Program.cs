using System;

namespace _4.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometres = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            //            •	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            double priceForTaxiDay = 0.79;
            double priceForTaxiNight = 0.9;
            double startPrice = 0.7;
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            double priceForBus = 0.09;
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            double priceForTrain = 0.06;
            if (kilometres < 20)
            {
                if (timeOfDay == "day")
                {
                    double price = startPrice + (kilometres * priceForTaxiDay);
                    Console.WriteLine("{0:f2}", price);
                }
                else if (timeOfDay == "night")
                {
                    double price = startPrice + (kilometres * priceForTaxiNight);
                    Console.WriteLine("{0:f2}", price);
                }
            }
            else if (kilometres >= 20 && kilometres < 100)
            {
                double price = kilometres * priceForBus;
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                double price = kilometres * priceForTrain;
                Console.WriteLine("{0:f2}", price);

            }
        }
    }
}

