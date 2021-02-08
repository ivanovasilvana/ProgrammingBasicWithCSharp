using System;

namespace _06._PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAirLine = int.Parse(Console.ReadLine());


            int countOfPassengers = 0;
            int allPassingers = 0;
            double average = 0;
            int counter = 0;
            double max = double.MinValue;
            string bestCompany = "";

            for (int i = 1; i <= countOfAirLine; i++)
            {
                string name = Console.ReadLine();

                while (true)
                {
                   string command = Console.ReadLine();

                    if (command == "Finish")
                    {
                        break;
                    }

                    else
                    {
                        counter++;
                        countOfPassengers = int.Parse(command);
                        allPassingers += countOfPassengers;
                        average = Math.Floor((allPassingers * 1.0) / (counter * 1.0));
                    }
                }

                if (average > max)
                {
                    max = average;
                    bestCompany = name;
                }
                Console.WriteLine($"{name}: {average} passengers.");
                counter = 0;
                allPassingers = 0;
            }
            Console.WriteLine($"{bestCompany} has most passengers per flight: {max}");
        }
    }
}
