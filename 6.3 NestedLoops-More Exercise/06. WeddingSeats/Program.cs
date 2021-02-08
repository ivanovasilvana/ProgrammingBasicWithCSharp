using System;

namespace _06._WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char end = char.Parse(Console.ReadLine());
            int countOfRowA = int.Parse(Console.ReadLine());
            int countOfSeedsEvenRow = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char sector = 'A'; sector <= end; sector++)
            {
                for (int rows = 1; rows <= countOfRowA; rows++)
                {
                    if (rows % 2 != 0)
                    {
                        for (int seeds = 97; seeds < 97 + countOfSeedsEvenRow; seeds++)
                        {
                            Console.WriteLine($"{sector}{rows}{Convert.ToChar(seeds)}");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int seeds = 97; seeds < 97 + countOfSeedsEvenRow + 2; seeds++)
                        {
                            Console.WriteLine($"{sector}{rows}{Convert.ToChar(seeds)}");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
