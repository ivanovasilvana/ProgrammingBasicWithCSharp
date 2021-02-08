using System;

namespace _1.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottleOfDetergent = int.Parse(Console.ReadLine());
            int dishDetergent = bottleOfDetergent * 750;

            int counter = 0;
            int countOfPlate = 0;
            int countOfPot = 0;
            while (true)
            {
                counter++;
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                else
                {
                    int dishes = int.Parse(input);

                    if (counter % 3 == 0)
                    {
                        countOfPot += dishes;
                        dishDetergent -= dishes * 15;
                    }

                    else
                    {
                        countOfPlate += dishes;
                        dishDetergent -= dishes * 5;
                    }

                }
                if (dishDetergent < 0)
                {
                    break;
                }
            }
            if (dishDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(dishDetergent)} ml. more necessary!");
            }

            else
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{countOfPlate} dishes and {countOfPot} pots were washed.");
                Console.WriteLine($"Leftover detergent {dishDetergent} ml.");
            }
        }
    }
}
