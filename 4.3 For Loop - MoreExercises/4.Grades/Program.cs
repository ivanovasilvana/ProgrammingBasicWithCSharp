using System;

namespace _4.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double sum = 0;
            double gradefrom2to2_99 = 0;
            double gradefrom3to3_99 = 0;
            double gradefrom4to4_99 = 0;
            double gradefrom5to6 = 0;

            for (int i = 1; i <= students; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                sum += grades;
                if (grades >= 2 && grades < 3 )
                {
                    gradefrom2to2_99 ++;
                }
                else if (grades >= 3 && grades < 4)
                {
                    gradefrom3to3_99 ++;
                }
                else if (grades >= 4 && grades < 5)
                {
                    gradefrom4to4_99 ++;
                }
                else if (grades >= 5 && grades <= 6)
                {
                    gradefrom5to6 ++;
                }
            }
            double average = sum / students;

            Console.WriteLine($"Top students: {(gradefrom5to6 / students) * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(gradefrom4to4_99 / students) * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(gradefrom3to3_99 / students) * 100:f2}%");
            Console.WriteLine($"Fail: {(gradefrom2to2_99 / students) * 100:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
