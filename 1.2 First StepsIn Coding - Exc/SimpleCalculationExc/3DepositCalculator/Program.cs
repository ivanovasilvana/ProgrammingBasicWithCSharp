using System;

namespace _3DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 3 реда:
            //1.Депозирана сума – реално число в интервала[100.00 … 10000.00];
            double amount = double.Parse(Console.ReadLine());
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12];
            int depositDue = int.Parse(Console.ReadLine());
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00];
            double annualInterest = double.Parse(Console.ReadLine());
            //4.Пресмятания:
            //Натрупана лихва:
            double interest = (amount * annualInterest)/100;
            //лихвата за един месец:
            double interestPerMonth = interest / 12;
            //общата сума: депозираната сума+ лихвата за един месец * срока на депозита
            double totalSum = amount + depositDue * interestPerMonth; 
            //output
            Console.WriteLine(totalSum);
        }
    }
}
