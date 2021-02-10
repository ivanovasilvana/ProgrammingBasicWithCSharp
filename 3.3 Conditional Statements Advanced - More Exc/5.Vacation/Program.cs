using System;

namespace _5.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            string location = "";
            string destination = "";

            switch (season)
            {
                case "Summer":
                    if (budget <= 1000)
                    {
                        location = "Camp";
                        destination = "Alaska";
                        price = budget * 0.65;
                    }
                   else if (budget > 1000 && budget <= 3000)
                    {
                        location = "Hut";
                        destination = "Alaska";
                        price = budget * 0.8;
                    }
                    else if (budget > 3000)
                    {
                        location = "Hotel";
                        destination = "Alaska";
                        price = budget * 0.9;
                    }
                    break;

                case "Winter":
                    if (budget <= 1000)
                    {
                        location = "Camp";
                        destination = "Morocco";
                        price = budget * 0.45;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        location = "Hut";
                        destination = "Morocco";
                        price = budget * 0.6;
                    }
                    else if (budget > 3000)
                    {
                        location = "Hotel";
                        destination = "Morocco";
                        price = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"{destination} - {location} - {price:f2}");
        }
    }
}
