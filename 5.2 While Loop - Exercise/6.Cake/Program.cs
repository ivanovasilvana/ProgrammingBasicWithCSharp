using System;

namespace _6.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lengthOfCake = int.Parse(Console.ReadLine());

            int volumeOfCake = widthOfCake * lengthOfCake;
            int volumeofPiеce = 1;
            int countOfPieces = volumeOfCake / volumeofPiеce;

            string input = Console.ReadLine();

            while (countOfPieces >= 0)
            {
                if (input == "STOP")
                {
                    break;
                }
            int pieces = int.Parse(input);
            countOfPieces -= pieces;
            input = Console.ReadLine();
            }
            if (countOfPieces >= 0)
            {
                Console.WriteLine($"{countOfPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(countOfPieces)} pieces more.");
            }
        }
    }
}
