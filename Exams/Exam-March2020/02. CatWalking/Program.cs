using System;

namespace _02._CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int countOfWalking = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());

            int sumMinutes = minutes * countOfWalking;
            int burnCal = sumMinutes * 5;
            double calNeeded = cal * 0.5;
            if (burnCal >= calNeeded)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCal}.");
            }
        }
    }
}
