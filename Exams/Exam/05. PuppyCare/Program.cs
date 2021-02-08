using System;

namespace _05._PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int foodInGr = foodInKg * 1000;
            int sumEatenFood = 0;

            while (command != "Adopted")
            {
                int eatenFood = int.Parse(command);
                sumEatenFood += eatenFood;

                command = Console.ReadLine();
            }
            if (sumEatenFood <= foodInGr)
            {
                int leftovers = foodInGr - sumEatenFood;
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else
            {
                int foodNeeded = sumEatenFood - foodInGr;
                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }
        }
    }
}
