using System;

namespace _06GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statis = int.Parse(Console.ReadLine());
            double clothesForStatist = double.Parse(Console.ReadLine());
            double decor = budget * 0.10;
            double priceForClothes = statis * clothesForStatist;
            if (statis > 150)
            {
                double discount = priceForClothes * 0.1;
                priceForClothes -= discount;
            }
            double totalMoney = decor + priceForClothes;
            if (totalMoney <= budget)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (totalMoney > budget)
            {
                double moneyYouNeed = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyYouNeed:f2} leva more.");
            }
        }
    }
}

