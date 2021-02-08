using System;

namespace _5._ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            int count = 0;
            for (int m = 1; m <= man; m++)
            {
                for (int f = 1; f <= woman; f++)
                {
                    count++;
                    if (count <= maxTables)
                    {
                        Console.Write($"({m} <-> {f}) ");
                    }

                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

