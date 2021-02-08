using System;

namespace _7.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0;

            switch (group)
            {
                case "girls":
                    if (season == "Winter")
                    {
                        sport = "Gymnastics";

                        price = students * nights * 9.6;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Spring")
                    {
                        sport = "Athletics";

                        price = students * nights * 7.2;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Summer")
                    {
                        sport = "Volleyball";

                        price = students * nights * 15;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;

                case "boys":
                    if (season == "Winter")
                    {
                        sport = "Judo";

                        price = students * nights * 9.6;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Spring")
                    {
                        sport = "Tennis";

                        price = students * nights * 7.2;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Summer")
                    {
                        sport = "Football";

                        price = students * nights * 15;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;

                case "mixed":
                    if (season == "Winter")
                    {
                        sport = "Ski";

                        price = students * nights * 10;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Spring")
                    {
                        sport = "Cycling";
                        price = students * nights * 9.5;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Summer")
                    {
                        sport = "Swimming";
                        price = students * nights * 20;
                        if (students >= 50)
                        {
                            price -= price * 0.5;
                        }
                        else if (students >= 20 && students < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (students >= 10 && students < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
