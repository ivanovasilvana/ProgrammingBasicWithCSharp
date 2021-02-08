using System;

namespace _01._Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForPage = double.Parse(Console.ReadLine());
            double priceForMain = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double priceFotDesigne = double.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());

            double startSum = priceForPage * 899 + priceForMain * 2;
            double sum = startSum - startSum * discount / 100;
            double sumWithDesigne = sum + priceFotDesigne;
            double finaleSum = sumWithDesigne - sumWithDesigne * procent / 100;

            Console.WriteLine($"Avtonom should pay {finaleSum:f2} BGN.");
        }
    }
}
