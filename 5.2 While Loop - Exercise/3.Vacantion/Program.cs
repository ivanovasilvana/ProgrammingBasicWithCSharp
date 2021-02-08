using System;

namespace _3.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());

            int days = 0;
            int daysSpend = 0;

            while (moneyOwned < moneyNeeded)
            {
                days++;
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (input == "spend")
                {
                    daysSpend++;
                    if (daysSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }

                    moneyOwned -= money;
                    if (moneyOwned < 0)
                    {
                        moneyOwned = 0;
                    }
                }
                else if (input == "save")
                {
                    daysSpend = 0;
                    moneyOwned += money;
                }
            }
            if (moneyOwned >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
