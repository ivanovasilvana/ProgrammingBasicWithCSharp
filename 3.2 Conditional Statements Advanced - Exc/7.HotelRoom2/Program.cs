using System;

namespace _7.HotelRoom2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctoberStudioPrice = 50;
            const double mayAndOctoberAartamentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.2;
            const double juneAndSeptemberApartamentPrice = 68.7;
            const double julyandAugustStudioPrice = 76;
            const double julyandAugustApartamentPrice = 77;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartament = 0;

            switch (month)
            {
                case "May":
                case "October":
                        priceForStudio = mayAndOctoberStudioPrice * nights;
                        priceForApartament = mayAndOctoberAartamentPrice * nights;
                    if (nights > 7 && nights < 14)
                    {
                        priceForStudio -= priceForStudio * 0.05 ;
                    }
                    else if (nights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.3;
                    }
                    break;

                case "June":
                case "September":
                    priceForStudio = juneAndSeptemberStudioPrice * nights;
                    priceForApartament = juneAndSeptemberApartamentPrice * nights;
                    if (nights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.2;
                    }
                    break;
                    
                case "July":
                case "August":
                    priceForStudio = julyandAugustStudioPrice * nights;
                    priceForApartament = julyandAugustApartamentPrice * nights;
                    break;
            }
            if (nights > 14)
            {
                priceForApartament -= priceForApartament * 0.1;
            }
            Console.WriteLine($"Apartment: {priceForApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
        }
    }
}
