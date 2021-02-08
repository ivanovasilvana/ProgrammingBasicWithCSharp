using System;

namespace _3NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rosesPrice = 5;
            const double dhaliasPrice = 3.8;
            const double tulipsPrice = 2.8;
            const double daffodiPrice = 3;
            const double gladiolusPrice = 2.5;
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            if (flowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    totalMoney -= numberOfFlowers * rosesPrice * 0.1;
                }
                totalMoney += numberOfFlowers * rosesPrice;
            }
            else if (flowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    totalMoney -= numberOfFlowers * dhaliasPrice * 0.15;
                }
                totalMoney += numberOfFlowers * dhaliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    totalMoney -= numberOfFlowers * tulipsPrice * 0.15;
                }
                totalMoney += numberOfFlowers * tulipsPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    totalMoney += numberOfFlowers * daffodiPrice * 0.15;
                }
                totalMoney += numberOfFlowers * daffodiPrice;
            }
            else if (flowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    totalMoney += numberOfFlowers * gladiolusPrice * 0.20;
                }
                totalMoney += numberOfFlowers * gladiolusPrice;
            }
            if (budget>=totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = totalMoney - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeed:f2} leva more.");
            }
        }
    }
}
