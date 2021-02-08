using System;

namespace _3.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCargos = int.Parse(Console.ReadLine());

            // до 3 тона
            double microbus = 200;
            // от 4 до 11 тона
            double truck = 175;
            // повече от 12 
            double train = 120;
           
            double cargosForMicrobus = 0;
            double cargosForTruck = 0;
            double cargosForTrain = 0;
            double priceForTransport = 0;
            double sumTon = 0;

            for (int i = 1; i <= countOfCargos; i++)
            {
                int ton = int.Parse(Console.ReadLine());
                sumTon += ton;

                if (ton <= 3)
                {
                    cargosForMicrobus += ton;
                    priceForTransport += ton * microbus;
                   
                }
                else if (ton >= 4 && ton <= 11 )
                {
                    cargosForTruck += ton;
                    priceForTransport += ton * truck;
                   
                }
                else
                {
                    cargosForTrain += ton;
                    priceForTransport += ton * train;
                }
            }
            double sum = priceForTransport / sumTon;

            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"{(cargosForMicrobus/sumTon)*100:f2}%");
            Console.WriteLine($"{(cargosForTruck / sumTon) * 100:f2}%");
            Console.WriteLine($"{(cargosForTrain / sumTon) * 100:f2}%");
        }
    }
}
