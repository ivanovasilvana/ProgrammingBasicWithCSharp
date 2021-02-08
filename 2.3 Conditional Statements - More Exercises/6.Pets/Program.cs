using System;

namespace _6.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodForDogInKg = double.Parse(Console.ReadLine());
            double foodForCatInKg = double.Parse(Console.ReadLine());
            double foodForTurtleInGr = double.Parse(Console.ReadLine());

            double foodForTurtleInKg = foodForTurtleInGr / 1000;
            double sumFood = days * (foodForDogInKg + foodForCatInKg + foodForTurtleInKg);

            if (sumFood <= food)
            {
                double foodLeft = Math.Floor (food - sumFood);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else
            {
                double foodNeeded = Math.Ceiling(sumFood - food);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
