using System;

namespace _08CircleAreAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, като форматирате изхода в следния вид: "<calculated area>"
            //"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double parameter = 2 * radius * Math.PI;
            Console.WriteLine($"<calculated area> {area:f2}");
            Console.WriteLine($"<calculated parametre> {parameter:f2}");
        }
    }
}
