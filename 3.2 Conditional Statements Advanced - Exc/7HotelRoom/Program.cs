using System;

namespace _7HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctomberStudioPrice = 50;
            const double mayAndOctomberAartamentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.2;
            const double juneAndSeptemberApartamentPrice = 68.7;
            const double julyandAugustStudioPrice = 76;
            const double julyandAugustApartamentPrice = 77;
            double totalMoneyForApartament = 0;
            double totalMoneyForStudio = 0;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


           switch (month)
            {
                case "May":
                case "Octomber":
                    if(nights >= 7 && nights <= 14)
                    {
                        double discountForStudio = mayAndOctomberStudioPrice * 0.05;
                        totalMoneyForStudio = (mayAndOctomberStudioPrice - discountForStudio) * nights;
                        totalMoneyForApartament = mayAndOctomberAartamentPrice;
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                    else if (nights > 14)
                    {
                        double discountForStudio = mayAndOctomberStudioPrice * 0.3;
                        double discountForApartament = mayAndOctomberAartamentPrice * 0.1;
                        totalMoneyForStudio = (mayAndOctomberStudioPrice - discountForStudio) * nights;
                        totalMoneyForApartament =nights*( mayAndOctomberAartamentPrice-discountForApartament);
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv.");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                    break;
                case "June":
                case "September":
                    if (nights >= 7 && nights <= 14)
                    {
                        totalMoneyForApartament = juneAndSeptemberApartamentPrice*nights;
                        totalMoneyForStudio = juneAndSeptemberStudioPrice*nights;
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv.");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                    else if (nights > 14)
                    {
                        double discountForApartament= juneAndSeptemberApartamentPrice * 0.1;
                        double discountForStudio = julyandAugustStudioPrice * 0.2;
                        totalMoneyForStudio = nights * (julyandAugustStudioPrice - discountForStudio);
                        totalMoneyForApartament = nights * (julyandAugustApartamentPrice - discountForApartament);
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv.");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                    break;
                case "July":
                case "August":
                    if (nights >= 7 && nights <= 14)
                    {
                        totalMoneyForApartament = nights * julyandAugustApartamentPrice;
                        totalMoneyForStudio = nights * julyandAugustStudioPrice;
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv.");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                    else if (nights > 14)
                    {
                        double discountForApartament = julyandAugustApartamentPrice * 0.1;
                        totalMoneyForStudio = nights * julyandAugustStudioPrice;
                        totalMoneyForApartament = nights * (julyandAugustApartamentPrice - discountForApartament);
                        Console.WriteLine($"Apartment: {totalMoneyForApartament:f2} lv.");
                        Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
                    }
                break;
            }
        }
    }
}
