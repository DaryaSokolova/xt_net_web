using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Triangle : Figure
    {
        private int a1;
        private int a2;
        private int a3;
        public Triangle(int _a1, int _a2, int _a3)
        {
            a1 = _a1;
            a2 = _a2;
            a3 = _a3;
        }

        public int _a1
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                {
                    a1 = value;
                }
            }
            get { return a1; }
        }

        public int _a2
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                {
                    a2 = value;
                }
            }
            get { return a2; }
        }

        public int _a3
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                {
                    if ((value + a1 < a2) || (value + a2 < a1) || (a1 + a2 < value))
                    {
                        throw new Exception("Нарушено правило создания треугольника");
                    }
                    else
                    {
                        a3 = value;
                    }
                }
            }
            get { return a3; }
        }

        public override void Enter()
        {
            _a1 = Convert.ToInt32(Console.ReadLine());
            _a2 = Convert.ToInt32(Console.ReadLine());
            _a3 = Convert.ToInt32(Console.ReadLine());
        }

        public override void Delete()
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
        }

        public override string GetInfo()
        {
            return ($"ТРЕУГОЛЬНИК: Стoроны: {a1}, {a2}, {a3} Периметр: {GetPerimeter()} Площадь: {GetArea()}");
        }

        public override string StringEnter()
        {
            return ("Введите параметры (a1 a2 a3):");
        }

        public override double GetPerimeter() => a1 + a2 + a3;

        public override double GetArea() => Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - a1) * (GetPerimeter() / 2 - a2) * (GetPerimeter() / 2 - a3));
    }
}
