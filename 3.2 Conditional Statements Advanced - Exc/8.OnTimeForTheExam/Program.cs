using System;

namespace _8.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {


            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());

            int examTime = (hourExam * 60) + minutesExam;
            int arrivalTime = (hourArrive * 60) + minutesArrive;
            int diffTime = Math.Abs(arrivalTime - examTime);

            if (arrivalTime > examTime)
            {
                if (diffTime <= 59 && diffTime > 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffTime} minutes after the start");
                }
                else
                {
                    int hour = diffTime / 60;
                    int minutes = diffTime % 60;
                    Console.WriteLine("Late");
                    if (minutes > 10)
                    {
                        Console.WriteLine($"{hour}:{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:0{minutes} hours after the start");
                    }
                }
            }

            else if (examTime == arrivalTime)
            {
                Console.WriteLine("On Time");
            }

            else if (examTime <= (arrivalTime + 30))
            {
                Console.WriteLine("On Time");
                Console.WriteLine($"{diffTime} minutes before the start");
            }
            else if (examTime > (arrivalTime + 30))
            {
                if (diffTime <= 59 && diffTime > 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffTime} minutes before the start");
                }
                else
                {
                    int hour = diffTime / 60;
                    int minutes = diffTime % 60;
                    Console.WriteLine("Early");
                    if (minutes > 10)
                    {
                        Console.WriteLine($"{hour}:{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:0{minutes} hours before the start");
                    }
                }
            }
        }
    }
}
