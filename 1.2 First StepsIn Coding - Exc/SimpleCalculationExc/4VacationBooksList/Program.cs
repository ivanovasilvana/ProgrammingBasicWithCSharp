using System;

namespace _4VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 3 реда:
            //1.Брой страници в текущата книга – цяло число в интервала[1…1000];
            int pagesInCurrentBook = int.Parse(Console.ReadLine());
            //2.Страници, които може да прочита за 1 час – реално число в интервала[1.00…1000.00];
            double pagesForOneHour = double.Parse(Console.ReadLine());
            //3.Броя на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000]
            int daysForTheBook = int.Parse(Console.ReadLine());
            //Общото време за четене на книгата: броч страници/страниците за един час
            double timesForOneBook = pagesInCurrentBook / pagesForOneHour;
            //Изчисляваме необходимите часове на ден: общото време за четене/дните,за които трябва да се прочете
            double hoursForOneDay = timesForOneBook / daysForTheBook;
            //Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.
            Console.WriteLine(hoursForOneDay);

        }
    }
}
