using System;

namespace _2.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int counter = 0;
            int counterCS = 0;
            int counterCC = 0;
            int cashMoney = 0;
            int cardMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();
                counter++;
                
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                else
                {
                    int priceForObjects = int.Parse(input);

                    if (counter % 2 != 0)
                    {
                        if (priceForObjects > 100)
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            cashMoney += priceForObjects;
                            Console.WriteLine("Product sold!");
                            counterCS++;
                        }
                    }

                    else
                    {
                        if (priceForObjects < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            cardMoney += priceForObjects;
                            Console.WriteLine("Product sold!");
                            counterCC++;
                        }
                    }
                }
                
                if (cardMoney + cashMoney >= sum)
                {
                    break;
                }
            }

            if (cardMoney + cashMoney >= sum)
            {
                double averageCS = 1.0 * cashMoney / counterCS;
                double averageCC = 1.0 * cardMoney / counterCC;
                Console.WriteLine($"Average CS: {averageCS:f2}");
                Console.WriteLine($"Average CC: {averageCC:f2}");
            }
        }
    }
}
