using System;
using System.Runtime.InteropServices.ComTypes;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double schoolarShipForExelentResult = Math.Floor(averageGrade * 25);
            double socialScholarShip = Math.Floor(0.35 * minimalSalary);

            if (income >= minimalSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {schoolarShipForExelentResult} BGN");
            }
            else if (income >= minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageGrade >= 5.5 && socialScholarShip <= schoolarShipForExelentResult)
            {
                Console.WriteLine($"You get a scholarship for excellent results {schoolarShipForExelentResult} BGN");
            }
            else if (income < minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
            }
            else if (income < minimalSalary && averageGrade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
