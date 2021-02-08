using System;

namespace _04._MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMovie = int.Parse(Console.ReadLine());

            double higestRating = double.MinValue;
            double lowestRating = double.MaxValue;
            string worstMovie = "";
            string bestMovie = "";
            double sumRating = 0;

            for (int i = 0; i < countOfMovie; i++)
            {
                string nameOfMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sumRating += rating;

                if (rating > higestRating)
                {
                    higestRating = rating;
                    bestMovie = nameOfMovie;
                }

                else if (rating < lowestRating)
                {
                    lowestRating = rating;
                    worstMovie = nameOfMovie;
                }

            }

            double average = sumRating / countOfMovie;
            Console.WriteLine($"{bestMovie} is with highest rating: {higestRating:f1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
