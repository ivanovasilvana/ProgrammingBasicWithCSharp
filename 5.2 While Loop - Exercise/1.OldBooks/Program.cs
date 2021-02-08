using System;

namespace _1.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string nextBookName = Console.ReadLine();
            int counter = 0;
            bool isBookHere = false;

            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    isBookHere = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isBookHere)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
