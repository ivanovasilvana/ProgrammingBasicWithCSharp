using System;

namespace ConsoleApp1
{
    class Program
        {
            static void Main(string[] args)
            {
                //            Напишете програма, която чете от конзолата три числа b1, b2 и h и пресмята лицето на трапец с основи b1 и b2 и височина h.Формулата за лице на трапец е(b1 +b2) *h / 2.
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (((firstSide + secondSide) * height) / 2);
                Console.WriteLine($"{area:f2}");
        }
        }
    }


    

