﻿using System;

namespace _05TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Учебна зала има правоъгълен размер w на h метра, без колони във вътрешността си.Залата е разделена на две части – лява и дясна, с коридор приблизително по средата.В лявата и в дясната част има редици с бюра. В задната част на залата има голяма входна врата.В предната част на залата има катедра с подиум за преподавателя.Едно работно място заема 70 на 120 cm(маса с размер 70 на 40 cm + място за стол и преминаване с размер 70 на 80 cm).Коридорът е широк поне 100 cm.Изчислено е, че заради входната врата(която е с отвор 160 cm) се губи точно 1 работно място, а заради катедрата(която е с размер 160 на 120 cm) се губят точно 2 работни места. Напишете програма, която въвежда размери на учебната зала и изчислява броя работни места в нея при описаното разположение(вж.фигурата).
            //Вход
            //От конзолата се четат 2 числа, по едно на ред: w(дължина в метри) и h(широчина в метри).
            double lengthInMetres = double.Parse(Console.ReadLine());
            double widthInMetres = double.Parse(Console.ReadLine());
            //Дължина на едно работно място:
            int workSpaceLength = 120;
            //Широчина на едно работно място:
            int workSpaceWidht = 70;
            int oneWorkSpace =((int) workSpaceLength * workSpaceWidht);
            int hallway = 100;         
            //Пресмятания:
            //1. бюра на ред: (широчината на залата - 100см за коридор)/широчината на едно работно мято
            double desksInOneRow = (int)((widthInMetres * 100) - hallway) / workSpaceWidht; //11бюра
            //2. брои редове: дължината на залата / дължината на бюрото 
            double countOfRow = (int)(lengthInMetres * 100) / workSpaceLength; //12реда
            //Изход
            //Да се отпечата на конзолата едно цяло число: броят места в учебната зала.
            double countOfSeets = ((int)(desksInOneRow * countOfRow) - 3); //
            Console.WriteLine(countOfSeets); //129
        }
    }
}