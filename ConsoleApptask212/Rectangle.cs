using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Rectangle : RectangularArea
    {
        public Rectangle(int A, int B)
        {
            a = A;
            b = B;
        }
        public string GetInfoAboutRectangle()
        {
            return ($"ПРЯМОУГОЛЬНИК: Длины: {a} и {b} Периметр: {Perimeter()} Площадь: {Square()}");
        }
        public string StringEnterRectangle()
        {
            return ("Введите параметры (a, b):");
        }
        public void EnterRectangle()
        {
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
        }
    }
}
