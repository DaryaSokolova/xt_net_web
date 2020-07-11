using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public class Rectangle : Quadrate
    {
        private int b;

        public Rectangle(int _a, int _b)
            : base(_a)
        {
            b = _b;
        }

        public int _b
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                    b = value;
            }
            get { return b; }
        }

        public override double GetPerimeter()
        {
            return 2*(a+b);
        }

        public override double GetArea()
        {
            return a*b;
        }

        public override string GetInfo()
        {
            return ($"ПРЯМОУГОЛЬНИК: Длины: {a} и {b} Периметр: {GetPerimeter()} Площадь: {GetArea()}");
        }

        public override string StringEnter()
        {
            return ("Введите параметры (a, b):");
        }

        public override void Delete()
        {
            a = 0;
            b = 0;
        }

        public override void Enter()
        {
            _a = Convert.ToInt32(Console.ReadLine());
            _b = Convert.ToInt32(Console.ReadLine());
        }
    }
}
