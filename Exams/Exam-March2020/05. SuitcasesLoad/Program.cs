using System;

namespace _05._SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityTank = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int counter = 0;
            double usedSpace = 0;

            while (input != "End")
            {
                double capacityOfSutcase = double.Parse(input);
                usedSpace += capacityOfSutcase;
                if (usedSpace >= capacityTank)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    capacityOfSutcase += capacityOfSutcase * 0.1;
                }
                input = Console.ReadLine();
            }
            if (usedSpace < capacityTank)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
