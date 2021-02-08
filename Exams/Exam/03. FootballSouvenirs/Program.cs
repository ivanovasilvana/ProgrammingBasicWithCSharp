using System;

namespace _03._FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int countOfSouvenirs = int.Parse(Console.ReadLine());

            double sum = 0;
            switch (team)
            {
                case "Argentina":
                    switch (souvenir)
                    {
                        case "flags":
                            sum = countOfSouvenirs * 3.25;
                            break;

                        case "caps":
                            sum = countOfSouvenirs * 7.2;
                            break;

                        case "posters":
                            sum = countOfSouvenirs * 5.1;
                            break;
                        case "stickers":
                            sum = countOfSouvenirs * 1.25;
                            break;

                    }
                    break;

                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags":
                            sum = countOfSouvenirs * 4.2;
                            break;

                        case "caps":
                            sum = countOfSouvenirs * 8.5;
                            break;

                        case "posters":
                            sum = countOfSouvenirs * 5.35;
                            break;

                        case "stickers":
                            sum = countOfSouvenirs * 1.2;
                            break;
                    }
                    break;

                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags":
                            sum = countOfSouvenirs * 2.75;
                            break;

                        case "caps":
                            sum = countOfSouvenirs * 6.9;
                            break;

                        case "posters":
                            sum = countOfSouvenirs * 4.95;
                            break;
                        case "stickers":
                            sum = countOfSouvenirs * 1.1;
                            break;
                    }
                    break;

                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags":
                            sum = countOfSouvenirs * 3.1;
                            break;

                        case "caps":
                            sum = countOfSouvenirs * 6.5;
                            break;

                        case "posters":
                            sum = countOfSouvenirs * 4.8;
                            break;
                        case "stickers":
                            sum = countOfSouvenirs * 0.9;
                            break;
                    }
                    break;
            }

            if (souvenir != "flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers" || team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                if (souvenir != "flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers")
                {
                    Console.WriteLine("Invalid stock!");
                }
                if (team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
                {
                    Console.WriteLine("Invalid country! ");
                }

            }
            else
            {
                Console.WriteLine($"Pepi bought {countOfSouvenirs} {souvenir} of {team} for {sum:f2} lv.");
            }
        }
    }
}
