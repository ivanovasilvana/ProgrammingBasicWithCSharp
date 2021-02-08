using System;

namespace _7.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standartTickets = 0;
            int kidTicket = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                int freeSpots = int.Parse(Console.ReadLine());
                int currentFreeSpot = freeSpots;

                while (currentFreeSpot > 0)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    currentFreeSpot--;

                    if (ticketType == "standard")
                    {
                        standartTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicket++;
                    }

                }
                double freeSpotsInprocents = 100 - ((currentFreeSpot * 1.0 / freeSpots) * 100);
                Console.WriteLine($"{input} - {freeSpotsInprocents:f2}% full.");
            }
            int totalTicket = standartTickets + studentTickets + kidTicket;
            double studentsTicketsPercentage = studentTickets * 1.0 / totalTicket * 100;
            double standartsTicketsPercentage = standartTickets * 1.0 / totalTicket * 100;
            double kidsTicketsPercentage = kidTicket * 1.0 / totalTicket * 100;

            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{studentsTicketsPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartsTicketsPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsPercentage:f2}% kids tickets.");
        }
    }
}
