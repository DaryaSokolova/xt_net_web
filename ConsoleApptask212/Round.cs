using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public class Round : RoundShape
    {
        public Round(int X, int Y, int Radius)
        {
            x = X;
            y = Y;
            radius = Radius;
        }
        public string GetInfoAboutRound()
        {
            return ($"КРУГ: Координаты: {x},{y} Радиус: {radius} Площадь: {GetArea()} Длина: {GetLength()}");
        }
        public string StringEnterRound()
        {
            return ("Введите параметры (x, y, r):");
        }
    }
}
