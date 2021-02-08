using System;

namespace _7ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForPuzzle = 2.6;
            double priceForDoll = 3;
            double priceForTeddyBear = 4.1;
            double priceForMinnion = 8.2;
            double priceForTruck = 2;

            double priceForTrip = double.Parse(Console.ReadLine());

            int countOfPuzzles = int.Parse(Console.ReadLine());
            int countOfDolls = int.Parse(Console.ReadLine());
            int countOfTeddyBears = int.Parse(Console.ReadLine());
            int countOfMinnions = int.Parse(Console.ReadLine());
            int countOfTrucks = int.Parse(Console.ReadLine());

            double sumFromToys = priceForPuzzle * countOfPuzzles + priceForDoll * countOfDolls + priceForTeddyBear * countOfTeddyBears + priceForMinnion * countOfMinnions + priceForTruck * countOfTrucks;
            int countOfToys = countOfPuzzles + countOfDolls + countOfTeddyBears + countOfMinnions + countOfTrucks;

            if (countOfToys>=50)
            {
                double sum = sumFromToys - (sumFromToys * 0.25);
                double priceForRent = sum * 0.1;
                double finaleSum = sum - priceForRent;
                if (finaleSum>=priceForTrip)
                {
                    double moneyLeft = finaleSum - priceForTrip;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeed = priceForTrip - finaleSum;
                    Console.WriteLine($"Not enough money! {moneyNeed:f2} lv needed.");
                }
            }
            else
            {
                double sum = sumFromToys;
                double priceForRent =sum * 0.1;
                double finaleSum = sum - priceForRent;
                if (finaleSum >= priceForTrip)
                {
                    double moneyLeft = finaleSum - priceForTrip;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    double moneyNeed = priceForTrip - finaleSum;
                    Console.WriteLine($"Not enough money! {moneyNeed:f2} lv needed.");
                }
            }
        }
    }
}
