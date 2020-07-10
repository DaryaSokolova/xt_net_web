using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Quadrate : RectangularArea
    {
        public Quadrate(int A)
        {
            a = A;
        }
        public string GetInfoAboutQuadrate()
        {
            return ($"КВАДРАТ: Длина: {a} Периметр: {Perimeter()} Площадь: {Square()}");
        }
        public string StringEnterQuadrate()
        {
            return ("Введите параметры (a):");
        }
        public void EnterQuadrate()
        {
            A = Convert.ToInt32(Console.ReadLine());
        }
    }
}
