using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public class Round : Figure
    {
        protected int x;
        protected int y;
        protected int radius;

        public Round(int _x, int _y, int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;
        }

        public int _radius
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                {
                    radius = value;
                }
            }
            get 
            { 
                return radius; 
            }
        }

        public override void Enter()
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            _radius = Convert.ToInt32(Console.ReadLine());
        }

        public override double GetPerimeter() => 2 * Math.PI * radius;

        public override double GetArea() => Math.PI * radius * radius;

        public override void Delete()
        {
            x = 0;
            y = 0;
            radius = 0;
        }

        public override string GetInfo()
        {
            return ($"КРУГ: Координаты: {x},{y} Радиус: {radius} Площадь: {GetArea()} Длина: {GetPerimeter()}");
        }

        public override string StringEnter()
        {
            return ("Введите параметры (x, y, r):");
        }
    }
}
