using System;

namespace _05._CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int food = foodInKg * 1000;
            int eatenFood = 0;
            while (input != "Adopted")
            {
                if (input != "Adopted")
                {
                int foodInGr = int.Parse(input);
                    eatenFood += foodInGr;
                }
                input = Console.ReadLine();
            }

            if (eatenFood <= food)
            {
                int foodLeft = food - eatenFood;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }

            else
            {
                int foodNeeded = eatenFood - food;
                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }
        }
    }
}
