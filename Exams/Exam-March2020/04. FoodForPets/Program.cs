using System;

namespace _04._FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            double sumFood = double.Parse(Console.ReadLine());

            double foodEatenByCat = 0;
            double foodEatenByDog = 0;
            double biscuits = 0;

            for (int i = 1; i <= countOfDays; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    biscuits += (dogFood + catFood) * 0.1;
                }
                foodEatenByCat += catFood;
                foodEatenByDog += dogFood;
            }
            double eatenFood = foodEatenByDog + foodEatenByCat;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{eatenFood / sumFood * 100:f2}% of the food has been eaten.");            Console.WriteLine($"{foodEatenByDog / eatenFood * 100:f2}% eaten from the dog.");            Console.WriteLine($"{foodEatenByCat / eatenFood * 100:f2}% eaten from the cat.");
        }
    }
}
