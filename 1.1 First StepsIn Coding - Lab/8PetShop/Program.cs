using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // От конзолата се четат 2 реда:
            //  1.Броят на кучетата – цяло число в интервала[0… 100]
            int countOfDogs = int.Parse(Console.ReadLine());
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            int countOfOthersAnimals = int.Parse(Console.ReadLine());
            //Цена на кучешката храна за един пакет:
            double foodOfDogs = 2.5;
            double foodOfOthersAnimals = 4;
            double priseForFood = (countOfDogs * foodOfDogs) + (countOfOthersAnimals * foodOfOthersAnimals);
            //На конзолата се отпечатва: "{крайната сума} lv."
            Console.WriteLine($"{priseForFood} lv.");

        }
    }
}
