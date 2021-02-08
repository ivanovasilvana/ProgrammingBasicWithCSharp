using System;

namespace _6._3_NestedLoops_MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstMax = int.Parse(Console.ReadLine());
            int secondMax = int.Parse(Console.ReadLine());
            int thirdMax = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstMax; i += 2)
            {
                for (int k = 2; k <= secondMax; k++)
                {
                    if (k == 2 || k == 3 || k == 5 || k == 7)
                    {
                        for (int l = 2; l <= thirdMax; l += 2)
                        {
                            Console.WriteLine($"{i} {k} {l}");
                        }
                    }
                }
            }
        }
    }
}


