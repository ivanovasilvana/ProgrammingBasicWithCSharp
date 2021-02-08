using System;

namespace _2.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Брой незадоволителни оценки:
            int filedTreshold = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();

            int filedTime = 0; // брояч незадоволителни оценки
            int slovedProblems = 0; // брояч решени проблеми
            double marksSum = 0; // сума на всички оценки
            string lastProblem = ""; // име на последната задача
            bool isPerfect = true; // дали се е провалил

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                marksSum+= grade;
                slovedProblems++;
                lastProblem = problemName;

                if (grade <= 4)
                {
                    filedTime++;

                    if (filedTime >= filedTreshold)
                    {
                        isPerfect = false;
                        break;
                    }
                }
                problemName = Console.ReadLine();
            }
            double gradeSum = 1.0 * marksSum / slovedProblems;
            if (isPerfect)
            {
                Console.WriteLine($"Average score: {gradeSum:f2}");
                Console.WriteLine($"Number of problems: {slovedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {filedTime} poor grades.");
            }
        }
    }
}
