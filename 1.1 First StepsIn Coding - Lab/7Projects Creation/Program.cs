using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 реда:
            //1.Името на архитекта -текст
            string nameOfarchitec = (Console.ReadLine());
            //2.Брой на проектите -цяло число в интервала[0… 100]
            int countOfprojects = int.Parse(Console.ReadLine());
            int timeForOneProject = 3;
            int timeForAllProjects = countOfprojects * timeForOneProject;
            //На конзолата се отпечатва:
            //"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            Console.WriteLine($"The architect {nameOfarchitec} will need {timeForAllProjects} hours to complete {countOfprojects} project/s.");


        }
    }
}
