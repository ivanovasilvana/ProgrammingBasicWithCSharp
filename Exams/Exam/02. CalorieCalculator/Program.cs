using System;

namespace _02._CalorieCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double kg = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activity = Console.ReadLine();

            double BNM = 0;
            if (gender == "m")
            {
                BNM = 66 + (13.7 * kg) + (5 * high * 100) - (6.8 * age);
            }

            else if (gender == "f")
            {
                BNM = 655 + (9.6 * kg) + (1.8 * high * 100) - (4.7 * age);
            }
            double cal = 0;
            if (activity == "sedentary")
            {
                cal = BNM * 1.2;
            }
            else if (activity == "lightly active")
            {
                cal = BNM * 1.375;
            }
            else if (activity == "moderately active")
            {
                cal = BNM * 1.55;
            }
            else if (activity == "very active")
            {
                cal = BNM * 1.725;
            }
            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(cal)} calories per day.");
        }
    }
}
