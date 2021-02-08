using System;

namespace _03._EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int countOfSets = int.Parse(Console.ReadLine());

            double sum = 0;
            double finaleSum = 0;

            switch(fruit)
            {
                case "Watermelon":
                    if (set == "small")
                    {
                        sum = countOfSets * 2 * 56;
                    }

                    else if (set == "big")
                    {
                        sum = countOfSets * 5 * 28.7;
                    }
                break;

                case "Mango":
                    if (set == "small")
                    {
                        sum = countOfSets * 2 * 36.66;
                    }

                    else if (set == "big")
                    {
                        sum = countOfSets * 5 * 19.6;
                    }
                    break;

                case "Pineapple":
                    if (set == "small")
                    {
                        sum = countOfSets * 2 * 42.1;
                    }

                    else if (set == "big")
                    {
                        sum = countOfSets * 5 * 24.8;
                    }
                    break;

                case "Raspberry":
                    if (set == "small")
                    {
                        sum = countOfSets * 2 * 20;
                    }

                    else if (set == "big")
                    {
                        sum = countOfSets * 5 * 15.2;
                    }
                    break;
            }

            if (sum >= 400 && sum <= 1000)
            {
                finaleSum = sum - (sum * 0.15);
            }

            else if (sum > 1000)
            {
                finaleSum = sum - (sum * 0.5);
            }

            else
            {
                finaleSum = sum;
            }

            Console.WriteLine($"{finaleSum:f2} lv.");
        }
    }
}
