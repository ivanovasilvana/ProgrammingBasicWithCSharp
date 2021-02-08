using System;

namespace _8.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litresFuelInTank = double.Parse(Console.ReadLine());

            if(typeFuel != "Diesel" && typeFuel != "Gasoline" && typeFuel != "Gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (typeFuel == "Diesel")
            {
                if (litresFuelInTank >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if (typeFuel == "Gasoline")
            {
                if (litresFuelInTank >= 25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (typeFuel == "Gas")
            {
                if (litresFuelInTank >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
            }
        }
    }
}
