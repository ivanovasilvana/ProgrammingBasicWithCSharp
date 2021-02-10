using System;

namespace _04VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Градинар продавал реколтата от градината си на зеленчуковата борса.Продава зеленчуци за N лева на килограм и плодове за M лева за килограм. Напишете програма, която да пресмята приходите от реколтата в евро(ако приемем, че едно евро е равно на 1.94лв).
            //Вход
            //От конзолата се четат 4 числа, по едно на ред:
            //•	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            double priceForKgVegetables = double.Parse(Console.ReadLine());
            //•	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            double priceForKgFriuts = double.Parse(Console.ReadLine());
            //•	Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            int kgVegetables = int.Parse(Console.ReadLine());
            //•	Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]
            int kgFriuts = int.Parse(Console.ReadLine());
            //Изход
            //Да се отпечата на конзолата едно число: приходите от всички плодове и зеленчуци в евро.
            double sumInBGN = (priceForKgVegetables * kgVegetables) + (priceForKgFriuts * kgFriuts);
            double course = 1.94;
            double sumInEuro = sumInBGN/course;
            //Резултата да се форматира до втория знак след десетичния разделител
            Console.WriteLine($"{sumInEuro:f2}");

        }
    }
}
