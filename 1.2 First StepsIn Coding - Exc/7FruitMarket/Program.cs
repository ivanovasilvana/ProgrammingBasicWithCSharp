using System;

namespace _7FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // От конзолата се четат 5 реда:
            // 1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            double priceForStrawberry = double.Parse(Console.ReadLine());
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            double bananasInKg = double.Parse(Console.ReadLine());
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            double orangesInKg = double.Parse(Console.ReadLine());
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            double raspberryInKg = double.Parse(Console.ReadLine());
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            double strawberryInKg = double.Parse(Console.ReadLine());
            //•	цената на малините е на половина по-ниска от тази на ягодите;
            double priseForRaspberry = priceForStrawberry / 2;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
            double priseForOranges = priseForRaspberry - (priseForRaspberry * 0.40);
            //•	цената на бананите е с 80 % по - ниска от цената на малините.
            double priseForBananas = priseForRaspberry - (priseForRaspberry * 0.80);
            double sumForRaspberry = priseForRaspberry* raspberryInKg;
            double sumForBananas =priseForBananas* bananasInKg;
            double sumForOranges =priseForOranges * orangesInKg;
            double sumForStrawberry = priceForStrawberry * strawberryInKg;
            double finalSum = sumForBananas + sumForRaspberry + sumForStrawberry+sumForOranges;
            Console.WriteLine($"{finalSum:f2}");

        }
    }
}
