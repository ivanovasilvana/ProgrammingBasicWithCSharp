using System;

namespace _3.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapeforOneSquareMetre = double.Parse(Console.ReadLine());
            int wineWant = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapeForOneLitre = 2.5;

            double grape = vineyard * grapeforOneSquareMetre;
            double wine = (grape * 0.4) / grapeForOneLitre;
            if (wine < wineWant)
            {
                double wineNeeded = Math.Floor(wineWant - wine);
                Console.WriteLine($"It will be a tough winter! More {wineNeeded} liters wine needed.");
            }
            else if (wine >= wineWant)
            {
                double wineLeft = Math.Ceiling(wine - wineWant);
                double wineForWorkers = Math.Ceiling(wineLeft / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {wineForWorkers} liters per person.");
            }
        }
    }
}
