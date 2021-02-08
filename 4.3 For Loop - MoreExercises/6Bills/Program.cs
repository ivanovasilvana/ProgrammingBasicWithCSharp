using System;

namespace _6Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;

            double priceForElectricity = 0;
            double priceForOthers = 0;;
            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double others = (water + internet + electricity) + ((water + internet + electricity) * 0.2);
                priceForElectricity += electricity;
                priceForOthers += others;
            }
            double sumWater = months * water;
            double sumInternet = months * internet;
            double sum = sumWater + sumInternet + priceForElectricity + priceForOthers;
            double average = sum / months;

            Console.WriteLine($"Electricity: {priceForElectricity:f2} lv");
            Console.WriteLine($"Water: {sumWater:f2} lv");
            Console.WriteLine($"Internet: {sumInternet:f2} lv");
            Console.WriteLine($"Other: {priceForOthers:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
