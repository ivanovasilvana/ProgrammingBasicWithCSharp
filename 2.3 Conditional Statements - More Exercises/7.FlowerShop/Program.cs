using System;

namespace _7.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForMagnolia = 3.25;
            const double priceForHyacinth = 4.00;
            const double priceForRose = 3.50;
            const double priceForCactus = 8.0;

            int countOfMagnolias = int.Parse(Console.ReadLine());
            int countOfHyacinths = int.Parse(Console.ReadLine());
            int countOfRoses = int.Parse(Console.ReadLine());
            int countOfCactus = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            double sum = (priceForMagnolia * countOfMagnolias + priceForHyacinth * countOfHyacinths + priceForRose * countOfRoses + priceForCactus * countOfCactus);
            double finaleSum = sum - (sum * 0.05);

            if (finaleSum >= priceForGift)
            {
                double sumLeft = Math.Floor(finaleSum - priceForGift);
                Console.WriteLine($"She is left with {sumLeft} leva.");
            }
            else
            {
                double sumNeeded = Math.Ceiling(priceForGift - finaleSum);
                Console.WriteLine($"She will have to borrow {sumNeeded} leva.");
            }
        }
    }
}
