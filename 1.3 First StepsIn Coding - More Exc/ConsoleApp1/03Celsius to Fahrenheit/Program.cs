using System;

namespace _03Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете градуси по скалата на Целзий(°C) 
            double degreesInCelsius = double.Parse(Console.ReadLine());
            //и ги преобразува до градуси по скалата на Фаренхайт(°F).°F = °C × 1,8 + 32
            double degreesInFahrenheit = degreesInCelsius * 1.8 + 32;
            //Форматирате изхода до втория знак след десетичната запетая. 
            Console.WriteLine($"{degreesInFahrenheit:f2}");
        }
    }
}
