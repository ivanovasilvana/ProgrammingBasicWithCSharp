using System;

namespace _5.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                else
                {

                    double budget = double.Parse(Console.ReadLine());
                    double savedMoney = 0;

                    while (savedMoney < budget)
                    {
                        double sum = double.Parse(Console.ReadLine());
                        savedMoney += sum;
                    }
                Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}

