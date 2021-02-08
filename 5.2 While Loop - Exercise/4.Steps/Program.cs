using System;

namespace _4.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10000;
            int totoalStep = 0;

            while (totoalStep < target)
            {
                string input = Console.ReadLine();
                if (input== "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totoalStep += stepsLeft;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    totoalStep += steps;
                }
            }
            if (totoalStep >= target)
            {
                int stepsOver = totoalStep - target;
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int moreStepsNeeded = target - totoalStep;
                Console.WriteLine($"{moreStepsNeeded} more steps to reach goal.");
            }
        }
    }
}
