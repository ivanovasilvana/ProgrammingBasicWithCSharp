using System;

namespace _07HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която да пресмята колко литра боя е нужна за боядисването на къщa.Като за стените се използва зелена боя, а за покрива – червена.Разхода на зелената боя е 1 литър за 3.4 м2, а на червената – 1 литър за 4.3 м2.
            
            //                Вход
            //От конзолата се четат 3 реда:
            //            1.x – височината на къщата – реално число в интервала[2...100]
            double visochinaNaKushtata = double.Parse(Console.ReadLine());
            //2.y – дължината на страничната стена – реално число в интервала[2...100]
            double duljinaNaStranichnataStena = double.Parse(Console.ReadLine());
            //3.h – височината на триъгълната стена на прокрива – реално число в интервала[2...100]
            double visocchinaNaTriugulnataStranaNaKushtata = double.Parse(Console.ReadLine());
            //Изчисления:
            //Стените имат следните размери:
            //•	Предната и задната стена са квадрати със страна „x“
            double liceNaZadnaStena = visochinaNaKushtata * visochinaNaKushtata;
            //o на предната стена има правоъгълна врата с широчина 1.2м и височина 2м
            double liceNaVratata = 1.2 * 2;
            double liceNaPrednataStena = (visochinaNaKushtata * visochinaNaKushtata) - liceNaVratata;
            //o и на двете странични стени има по един квадратен прозорец със страна 1.5м
            double liceNaProzorec = 1.5 * 1.5;
            //•	Страничните стени са правоъгълници със страни „x“ и „y“
            double liceNaStranichniteSteni = 2*((visochinaNaKushtata * duljinaNaStranichnataStena) - liceNaProzorec);;
            //Покривът има следните размери:
            //•	Два правоъгълника със страни „x“ и „y“
            double liceNaPokriva1 = 2*(visochinaNaKushtata * duljinaNaStranichnataStena);
            //•	Два равностранни триъгълника със страна „x“ и височина „h“
            double liceNaPokriva2 =2* (visochinaNaKushtata * visocchinaNaTriugulnataStranaNaKushtata) / 2;
            double liceNaPokriva = liceNaPokriva1 + liceNaPokriva2;
            
            //Изход
            //Да се отпечатат на конзолата две числа всяко на нов ред:
            //•	Литрите зелена боя
            double zelenaBoya = (liceNaZadnaStena + liceNaPrednataStena + liceNaStranichniteSteni) / 3.4;
            Console.WriteLine($"{zelenaBoya:f2}");
            //•	Литритe червена боя
            double chervenaBoya = (liceNaPokriva1 + liceNaPokriva2) / 4.3;
            Console.WriteLine($"{chervenaBoya:f2}");
            //Форматирани до вторият знак след десетичната запетая.


        }
    }
}
