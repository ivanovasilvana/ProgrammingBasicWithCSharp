using System;

namespace _5.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double timesForWork = 8;
            double timeForStudy = days * 0.1;
            double hoursForWork = (days - timeForStudy) * timesForWork;
            double overtime = overtimeWorkers * days * 2;
            double sumHours = hoursForWork + overtime;
            if(sumHours>=hours)
            {
                double hourLeft = Math.Floor( sumHours - hours);
                Console.WriteLine($"Yes!{hourLeft} hours left.");
            }
          else
            {
                double hourNeeded =Math.Ceiling(hours - sumHours);
                Console.WriteLine($"Not enough time!{hourNeeded:f0} hours needed.");
            }
        }
    }
}
