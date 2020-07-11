using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Line : Figure
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Line(int _x1, int _x2, int _y1, int _y2)
        {
            x1 = _x1;
            x2 = _x2;
            y1 = _y1;
            y2 = _y2;
        }

        public override void Enter()
        {
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }

        public override void Delete()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }

        public override string GetInfo()
        {
            return ($"ЛИНИЯ: Координаты точек линии: ({x1},{y1}) и ({x2},{y2}), а длина равна: {GetPerimeter()}");
        }

        public override string StringEnter()
        {
            return ("Введите параметры (x1 x2 y1 y2):");
        }

        public override double GetPerimeter() => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }
}
