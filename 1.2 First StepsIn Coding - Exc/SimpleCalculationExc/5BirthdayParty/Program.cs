using System;

namespace _5BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //В сладкарница се провежда благотворителна кампания за събиране на средства, 
            //в която могат да се включат сладкари от цялата страна.Първоначално прочитаме от 
            //конзолата броя на дните, в които тече кампанията и броя на сладкарите, които ще се включат.
            //След това на отделни редове получаваме количеството на тортите, гофретите и палачинките, 
            //които ще бъдат приготвени от един сладкар за един ден. Трябва да се има предвид следния ценоразпис:
            //•	Торта - 45 лв.
           const double priceForCake = 45;
            //•	Гофрета - 5.80 лв.
            const double priceForWaffel = 5.8;
            //•	Палачинка – 3.20 лв.
           const double priceForPancake = 3.20;
            //1 / 8 от крайната сума ще бъде използвана за покриване на 
            //разходите за продуктите по време на кампанията. 
            //Да се напише програма, която изчислява сумата, която е събрана в края на кампанията.
            //Вход
            //От конзолата се четат 5 реда:
            // 1.Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            int campaingDays = int.Parse(Console.ReadLine());
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            int numberOfCooker = int.Parse(Console.ReadLine());
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            int numberOfCake = int.Parse(Console.ReadLine());
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            int numberOfWaffels = int.Parse(Console.ReadLine());
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]
            int numberOfPuncakes = int.Parse(Console.ReadLine());
            //Изчисления:
            double cakeTotalPrice = numberOfCake * priceForCake;
            double waffersTotalPrice = numberOfWaffels * priceForWaffel;
            double PunckaesTotalPrice = numberOfPuncakes * priceForPancake;
            //Обща сума за един ден: 
            double priceForOneDay = numberOfCooker * (cakeTotalPrice + PunckaesTotalPrice+ waffersTotalPrice);
            //Сума събрана от цялата кампания:
            double sumFromCampaing = priceForOneDay * campaingDays;
            //Сума след покриване на разходите:
            double finalePrice = sumFromCampaing - (sumFromCampaing / 8);
            //Да се отпечата на конзолата едно число:
            //•	парите, които са събрани.
            Console.WriteLine(finalePrice);

        }
    }
}
