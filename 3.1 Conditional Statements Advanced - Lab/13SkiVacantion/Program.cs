using System;

namespace _13SkiVacantion
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string mark = Console.ReadLine();

            double roomForOnePersonForOneNight = 18;
            double apartmentForOneNight = 25;
            double presidentApartmentForOneNight = 35;
            double price = 0;

            int nights = days - 1;
            switch (room)
            {
                case "room for one person":
                    price = nights * roomForOnePersonForOneNight;
                    if (mark == "positive")
                    {
                        price = price + (price * 0.25);
                    }
                    else if (mark == "negative")
                    {
                        price = price - (price * 0.1);
                    }
                    Console.WriteLine($"{price:f2}");
                    break;
                case "apartment":
                    if (days <= 10)
                    {
                        price = (nights * apartmentForOneNight) - (nights * apartmentForOneNight * 0.3);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    else if (days <= 15)
                    {
                        price = (nights * apartmentForOneNight) - (nights * apartmentForOneNight * 0.35);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    else
                    {
                        price = (nights * apartmentForOneNight) - (nights * apartmentForOneNight * 0.5);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    Console.WriteLine($"{price:f2}");
                    break;
                case "president apartment":
                    if (days <= 10)
                    {
                        price = (nights * presidentApartmentForOneNight) - (nights * presidentApartmentForOneNight * 0.1);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    else if (days < 15)
                    {
                        price = (nights * presidentApartmentForOneNight) - (nights * presidentApartmentForOneNight * 0.15);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    else
                    {
                        price = (nights * presidentApartmentForOneNight) - (nights * presidentApartmentForOneNight * 0.20);
                        if (mark == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else if (mark == "negative")
                        {
                            price = price - (price * 0.1);
                        }
                    }
                    Console.WriteLine($"{price:f2}");
                    break;
            }
        }
    }
}
