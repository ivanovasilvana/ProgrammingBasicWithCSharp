using System;

namespace _8FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // От конзолата се четат 4 реда:
            // 1.Дължина в см – цяло число в интервала[10 … 500]
            double lengthInCm = double.Parse(Console.ReadLine());
            //2.Широчина в см – цяло число в интервала[10 … 300]
            double widthInCm = double.Parse(Console.ReadLine());
            //3.Височина в см – цяло число в интервала[10… 200]
            double heightInCm = double.Parse(Console.ReadLine());
            //4.Процент  – реално число в интервала[0.000 … 100.000]
            double percentOfCapacity = double.Parse(Console.ReadLine());
            //1.обем на аквариум:
            double capacityOfTank = lengthInCm * widthInCm * heightInCm;
            //2.общо литри, които ще събере: 
            double totalWaterInLitres = capacityOfTank * 0.001;
            //3. проценти
            double percent = percentOfCapacity * 0.01;
            //4.литрите, които реално ще трябват 
            double realLitres = totalWaterInLitres * (1 - percent);
            //Изход: литрите вода, които ще  събира аквариума.
            Console.WriteLine($"{ realLitres: f2}");
        }
    }
}
