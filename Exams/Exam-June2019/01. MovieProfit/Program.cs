using System;

namespace _01._MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int countOfDays = int.Parse(Console.ReadLine());
            int countOfTickets = int.Parse(Console.ReadLine());
            double priceForTicet = double.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());

            double price = countOfDays * countOfTickets * priceForTicet;
            double forCinema = price * procent / 100;
            double sum = price - forCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {sum:f2} lv.");
        }
    }
}
