using System;

namespace _05._TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            double total = 0;
            int counter = 0;
            int allProducts = 0;
            

            while (comand != "Stop")
            {
               double price = double.Parse(Console.ReadLine());
                comand = Console.ReadLine();
                counter++;
                if (counter % 3 == 0)
                {
                    price = price / 2;
                }

                if (price + total > buget)
                {
                    double neededMoney = price + total - buget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    break;
                }

                allProducts++;
                total += price;
            }

            if (comand == "Stop")
            {
                Console.WriteLine($"You bought {allProducts} products for {total:f2} leva.");
            }
        }
    }
}