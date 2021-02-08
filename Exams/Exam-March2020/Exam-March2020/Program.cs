using System;

namespace Exam_March2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 биткойн = 1168 лева.
            double bitCoin = 1168;
            //1 китайски юан = 0.15 долара.
            double juan = 0.15;
            //1 долар = 1.76 лева.
            double dollar = 1.76;
            //1 евро = 1.95 лева.
            double euro = 1.95;

            //На първия ред – броят биткойни. Цяло число в интервала[0…20]
            int countOfBitcoins = int.Parse(Console.ReadLine());
            //На втория ред – броят китайски юана.Реално число в интервала[0.00… 50 000.00]
            double countOfJuangs = double.Parse(Console.ReadLine());
            //На третия ред – комисионната.Реално число в интервала[0.00... 5.00]
            double commision = double.Parse(Console.ReadLine());

            double bitCoins = bitCoin * countOfBitcoins;
            double juans = countOfJuangs * juan;
            double leva = bitCoins + juans * dollar;
            double sum = leva - (leva * commision / 100);
            double finaleSum = sum / euro;

            Console.WriteLine($"{finaleSum:f2}");
        }
    }
}
