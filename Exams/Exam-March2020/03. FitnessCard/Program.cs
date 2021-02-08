using System;

namespace _03._FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double sumNeeded = 0;
            double finaleSum = 0;

            switch(sport)
            {
                case "Gym":
                    if (sex == "m")
                    {
                        sumNeeded = 42;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 35;
                    }
                    break;

                case "Boxing":
                    if (sex == "m")
                    {
                        sumNeeded = 41;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 37;
                    }
                    break;

                case "Yoga":
                    if (sex == "m")
                    {
                        sumNeeded = 45;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 42;
                    }
                    break;

                case "Zumba":
                    if (sex == "m")
                    {
                        sumNeeded = 34;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 31;
                    }
                    break;

                case "Dances":
                    if (sex == "m")
                    {
                        sumNeeded = 51;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 53;
                    }
                    break;

                case "Pilates":
                    if (sex == "m")
                    {
                        sumNeeded = 39;
                    }

                    else if (sex == "f")
                    {
                        sumNeeded = 37;
                    }
                    break;
            }
            if (age <= 19)
            {
                finaleSum = sumNeeded - (sumNeeded * 0.2);
            }

            else
            {
                finaleSum = sumNeeded;
            }
            if (finaleSum < sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }

            else
            {
                double diff = finaleSum - sum;
                Console.WriteLine($"You don't have enough money! You need ${diff:f2} more.");
            }
        }
    }
}
