using System;

namespace _4.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string carClass = "";
            string carType = "";
            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Cabrio";
                        price = budget * 0.35;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Cabrio";
                        price = budget * 0.45;
                    }

                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Jeep";
                        price = budget * 0.65;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Jeep";
                        price = budget * 0.80;
                    }

                    break;
            }
            if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
