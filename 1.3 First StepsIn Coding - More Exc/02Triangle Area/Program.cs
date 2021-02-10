using System;

namespace _02Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата страна и височина на триъгълник 
            double side = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            //и пресмята неговото лице. Използвайте формулата за лице на триъгълник: area = a * h / 2. 
            double area = (side * high) / 2;
            //Форматирате изхода до втория знак след десетичната запетая.
            Console.WriteLine($"{area:f2}");
        }
    }
}
