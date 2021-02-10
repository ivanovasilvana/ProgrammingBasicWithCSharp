using System;

namespace _3.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfChrysanthemums = int.Parse(Console.ReadLine());
            int countOfRoses = int.Parse(Console.ReadLine());
            int countOfTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            int count = countOfChrysanthemums + countOfRoses + countOfTulips;
            double priceForChrysanthemumsSpringSummer = 2.0 * countOfChrysanthemums;
            double priceForChrysanthemumsAutumWinter = 3.75 * countOfChrysanthemums;
            double priceForRosesSpringSummer = 4.1 * countOfRoses;
            double priceForRosesAutumWinter = 4.5 * countOfRoses;
            double priceForTulipsSpringSummer = 2.5 * countOfTulips;
            double priceForTulipsAutumWinter = 3.75 * countOfTulips;
            double priceForArranging = 2;

            double money = 0;

            switch (season)
            {
                case "Spring":
                    priceForChrysanthemumsSpringSummer = 2 * countOfChrysanthemums;
                    priceForRosesSpringSummer = 4.1 * countOfRoses;
                    priceForTulipsSpringSummer = 2.5 * countOfTulips;

                    if (holiday == "Y")
                    {
                        priceForChrysanthemumsSpringSummer += priceForChrysanthemumsSpringSummer * 0.15;
                        priceForRosesSpringSummer += priceForRosesSpringSummer * 0.15;
                        priceForTulipsSpringSummer += priceForTulipsSpringSummer * 0.15;
                        money = priceForChrysanthemumsSpringSummer + priceForRosesSpringSummer + priceForTulipsSpringSummer;
                        if (countOfTulips > 7)
                        {
                            money -= money * 0.05;
                        }
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    else if (holiday == "N")
                    { 
                        money = priceForChrysanthemumsSpringSummer + priceForRosesSpringSummer + priceForTulipsSpringSummer;
                        if (countOfTulips > 7)
                        {
                            money -= money * 0.05;
                        }
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    break;

                case "Summer":
                    priceForChrysanthemumsSpringSummer = 2 * countOfChrysanthemums;
                    priceForRosesSpringSummer = 4.1 * countOfRoses;
                    priceForTulipsSpringSummer = 2.5 * countOfTulips;

                    if (holiday == "Y")
                    {
                        priceForChrysanthemumsSpringSummer += priceForChrysanthemumsSpringSummer * 0.15;
                        priceForRosesSpringSummer += priceForRosesSpringSummer * 0.15;
                        priceForTulipsSpringSummer += priceForTulipsSpringSummer * 0.15;
                        money = priceForChrysanthemumsSpringSummer + priceForRosesSpringSummer + priceForTulipsSpringSummer;
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    else if (holiday == "N")
                    {
                        money = priceForChrysanthemumsSpringSummer + priceForRosesSpringSummer + priceForTulipsSpringSummer;
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    break;
                case "Autumn":

                    priceForChrysanthemumsAutumWinter = 3.75 * countOfChrysanthemums;
                    priceForRosesAutumWinter = 4.5 * countOfRoses;
                    priceForTulipsAutumWinter = 4.15 * countOfTulips;

                    if (holiday == "Y")
                    {
                        priceForChrysanthemumsAutumWinter += priceForChrysanthemumsAutumWinter * 0.15;
                        priceForRosesAutumWinter += priceForRosesAutumWinter * 0.15;
                        priceForTulipsAutumWinter += priceForTulipsAutumWinter * 0.15;
                        money = priceForChrysanthemumsAutumWinter + priceForRosesAutumWinter + priceForTulipsAutumWinter;
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    else if (holiday == "N")
                    {
                        money = priceForChrysanthemumsAutumWinter + priceForRosesAutumWinter + priceForTulipsAutumWinter; if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    break;

                case "Winter":
                    priceForChrysanthemumsAutumWinter = 3.75 * countOfChrysanthemums;
                    priceForRosesAutumWinter = 4.5 * countOfRoses;
                    priceForTulipsAutumWinter = 4.15 * countOfTulips;

                    if (holiday == "Y")
                    {
                        priceForChrysanthemumsAutumWinter += priceForChrysanthemumsAutumWinter * 0.15;
                        priceForRosesAutumWinter += priceForRosesAutumWinter * 0.15;
                        priceForTulipsAutumWinter += priceForTulipsAutumWinter * 0.15;
                        money = priceForChrysanthemumsAutumWinter + priceForRosesAutumWinter + priceForTulipsAutumWinter;
                        if (countOfRoses >= 10)
                        {
                            money -= money * 0.1;
                        }
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    else if (holiday == "N")
                    {
                        money = priceForChrysanthemumsAutumWinter + priceForRosesAutumWinter + priceForTulipsAutumWinter;
                        if (countOfRoses >= 10)
                        {
                            money -= money * 0.1;
                        }
                        if (count > 20)
                        {
                            money -= money * 0.2;
                        }
                    }
                    break;
            }
            double totalMoney = money + priceForArranging;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
