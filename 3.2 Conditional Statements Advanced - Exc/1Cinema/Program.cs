using System;

namespace _3._3ConditionalStatementsExc
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0;
            //if (typeProjection == "Premiere")
            //{
            //    income = rows * colums * 12;
            //}
            //else if (typeProjection == "Normal")
            //{
            //    income = rows * colums * 7.5;
            //}
            //else if (typeProjection == "Discount") 
            //{
            //    income = rows * colums * 5;
            //}
            //Console.WriteLine($"{income:F2} leva");
            switch (typeProjection)
            {
                case "Premiere":
                    income = rows * colums * 12;
                    break;
                case "Normal":
                    income = rows * colums * 7.5;
                    break;
                case "Discount":
                    income = rows * colums * 5;
                    break;
                default:
                    Console.WriteLine("Invalid Statemant");
                    break;
            }
            Console.WriteLine($"{income:F2} leva"); Console.WriteLine($"{income:F2} leva");
        }
    }
}
