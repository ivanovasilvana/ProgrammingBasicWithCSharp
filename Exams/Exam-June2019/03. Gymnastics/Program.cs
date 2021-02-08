using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double mark = 0;

            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            mark = 9.100 + 9.400;
                            break;

                        case "hoop":
                            mark = 9.300 + 9.800;
                            break;

                        case "rope":
                            mark = 9.600 + 9.000;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            mark = 9.600 + 9.400;
                            break;

                        case "hoop":
                            mark = 9.550 + 9.750;
                            break;

                        case "rope":
                            mark = 9.500 + 9.400;
                            break;
                    }
                    break;
                        
                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            mark = 9.200 + 9.500;
                            break;

                        case "hoop":
                            mark = 9.450 + 9.350;
                            break;

                        case "rope":
                            mark = 9.700 + 9.150;
                            break;
                    }
                    break;
            }

            double diff = 20 - mark;
            double procent = diff / 20 * 100;
            Console.WriteLine($"The team of {country} get {mark:f3} on {instrument}.");
            Console.WriteLine($"{procent:f2}%");
        }
    }
}
