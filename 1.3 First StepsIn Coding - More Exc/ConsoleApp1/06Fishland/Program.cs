using System;

namespace _06Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //            Вход
            //            От конзолата се четат 5 числа:
            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            double priceForSkumria =double.Parse( Console.ReadLine());
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            double priceForCaca = double.Parse(Console.ReadLine());
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            double kgPalamud = double.Parse(Console.ReadLine());
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            double kgSafrid = double.Parse(Console.ReadLine());
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            double kgMidi = double.Parse(Console.ReadLine());
            //Изчисления:
            //•	Паламуд – 60 % по - скъп от скумрията:
            double priceForPalamud = (priceForSkumria * 0.6) + priceForSkumria;
            //•	Сафрид – 80 % по - скъп от цацата
            double priceForSafrid = (priceForCaca * 0.8) + priceForCaca;
            //•	Миди – 7.50 лв.за килограм
            double priceForMidi = 7.5;
            //Изход
            double sum = (kgPalamud * priceForPalamud) + (kgSafrid * priceForSafrid) + (kgMidi * priceForMidi);
            Console.WriteLine($"{sum:f2}");
            //Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката.Закръглено до вторият знак след десетичната запетая(1.2457-> 1.25).

        }
    }
}
