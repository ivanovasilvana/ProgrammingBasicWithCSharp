using System;

namespace _9.FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForGasoline = 2.22;
            const double priceForGas = 0.93;
            const double priceForDiesel = 2.33;

            const double discountGasoline = 0.18;
            const double discountGas = 0.08;
            const double discountDiesel = 0.12;

            string typeFuel = Console.ReadLine();
            double litresFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double sum = 0;

            switch (typeFuel)
            {
                case "Gasoline":
                    if (clubCard == "Yes")
                    {
                        sum = (priceForGasoline * litresFuel) - (discountGasoline * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if(litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = (priceForGasoline * litresFuel) - (discountGasoline * litresFuel);
                        }
                    }
                    else if (clubCard == "No")
                    {
                        sum = (priceForGasoline * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if (litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = priceForGasoline * litresFuel;
                        }
                    }
                    Console.WriteLine($"{sum:f2} lv.");
                        break;
                case "Gas":
                    if (clubCard == "Yes")
                    {
                        sum = (priceForGas * litresFuel) - (discountGas * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if (litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = (priceForGas * litresFuel) - (discountGas * litresFuel);
                        }
                    }
                    else if (clubCard == "No")
                    {
                        sum = (priceForGas * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if (litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = priceForGas * litresFuel;
                        }
                    }
                    Console.WriteLine($"{sum:f2} lv.");
                    break;
                case "Diesel":
                    if (clubCard == "Yes")
                    {
                        sum = (priceForDiesel * litresFuel) - (discountDiesel * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if (litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = (priceForDiesel * litresFuel) - (discountDiesel * litresFuel);
                        }
                    }
                    else if (clubCard == "No")
                    {
                        sum = (priceForDiesel * litresFuel);
                        if (litresFuel >= 20 && litresFuel <= 25)
                        {
                            sum = sum - (sum * 0.08);
                        }
                        else if (litresFuel > 25)
                        {
                            sum = sum - (sum * 0.1);
                        }
                        else
                        {
                            sum = priceForDiesel * litresFuel;
                        }
                    }
                    Console.WriteLine($"{sum:f2} lv.");
                    break; 
            }
        }
    }
}
