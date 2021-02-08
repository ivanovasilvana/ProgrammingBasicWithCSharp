using System;

namespace _6.AreaOfFigures2
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            //•	Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            if (figure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                area = sideOfSquare * sideOfSquare;
            }
            //•	Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            else if (figure == "rectangle")
            {
                double firstSideOfRectange = double.Parse(Console.ReadLine());
                double secondSideOfRectangle = double.Parse(Console.ReadLine());
                area = firstSideOfRectange * secondSideOfRectangle;
            }
            //•	Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            else if (figure == "circle")
            {
                double radiusOfCircle = double.Parse(Console.ReadLine());
                area = Math.PI * radiusOfCircle * radiusOfCircle;
            }
            //•	Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и дължината на височината към нея.
            else if (figure == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double highOfTriangle = double.Parse(Console.ReadLine());
                area = (sideOfTriangle * highOfTriangle) / 2;

            }
            Console.WriteLine($"{area:f3}");

        }
    }
}

