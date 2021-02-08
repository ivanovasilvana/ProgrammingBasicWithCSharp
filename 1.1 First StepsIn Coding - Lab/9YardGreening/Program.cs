using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цената на един кв. м.е 7.61лв със ДДС.Тъй като нейният двор е доста голям, 
            //фирмата изпълнител предлага 18 % отстъпка от крайната цена.
            double priseForOneSquareMeter = 7.61;
            //От конзолата се прочита само един ред:
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала[0.00… 10000.00]
            double area = double.Parse(Console.ReadLine());
            double price = area * priseForOneSquareMeter;
            double discount = price*0.18;
            double finalePrice = price - discount;
            //На конзолата се отпечатват два реда:
            //•	"The final price is: {крайна цена на услугата} lv."
            //•	"The discount is: {отстъпка} lv."
            Console.WriteLine($"The final price is {finalePrice} lv.");
            Console.WriteLine($"The discount is {discount}");

        }
    }
}
