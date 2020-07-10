using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Line
    {
        private protected int x1;
        private protected int x2;
        private protected int y1;
        private protected int y2;
        public Line(int X1, int X2, int Y1, int Y2)
        {
            x1 = X1;
            x2 = X2;
            y1 = Y1;
            y2 = Y2;
        }
        public void EnterLine()
        {
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public void DeleteLine()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }
        public string GetInfoAboutLine()
        {
            return ($"ЛИНИЯ: Координаты точек линии: ({x1},{y1}) и ({x2},{y2})");
        }
        public string StringEnterLine()
        {
            return ("Введите параметры (x1 x2 y1 y2):");
        }
        public double LengthLine() => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }
}
