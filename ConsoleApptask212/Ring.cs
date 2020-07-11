using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public class Ring : Round
    {
        private int innerRadius;

        public Ring(int _x, int _y, int _radius, int _innerRadius)
            : base(_x, _y, _radius)
        {
            innerRadius = _innerRadius;
        }

        public int _innerRadius
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                {
                    if (value >= radius)
                    {
                        throw new Exception("Фигура создана с ошибкой");
                    }
                    else
                    {
                        innerRadius = value;
                    }
                }
            }
            get
            {
                return innerRadius;
            }
        }

        public override void Enter()
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            _radius = Convert.ToInt32(Console.ReadLine());
            _innerRadius = Convert.ToInt32(Console.ReadLine());
        }

        public override double GetArea() => Math.PI * (radius * radius - innerRadius * innerRadius);

        public override void Delete()
        {
            x = 0;
            y = 0;
            radius = 0;
            innerRadius = 0;
        }

        public override string StringEnter()
        {
            return ("Введите параметры (x, y, r, innerRadius):");
        }

        public override string GetInfo()
        {
            return ($"КРУГ: Координаты: {x},{y} Радиус: {radius} Внутренний радиус: {innerRadius} Площадь: {GetArea()} Длина: {GetPerimeter()}");
        }
    }
}
