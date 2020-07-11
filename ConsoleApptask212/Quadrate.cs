using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public class Quadrate : Figure
    {
        protected int a;

        public Quadrate(int _a)
        {
            a = _a;
        }

        public int _a
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Фигура создана с ошибкой");
                }
                else
                    a = value;
            }
            get { return a; }
        }

        public override double GetPerimeter()
        {
            return 4*a;
        }

        public override double GetArea()
        {
            return a * a;
        }

        public override string GetInfo()
        {
            return ($"КВАДРАТ: Длины: {a} Периметр: {GetPerimeter()} Площадь: {GetArea()}");
        }

        public override string StringEnter()
        {
            return ("Введите параметры (a):");
        }

        public override void Delete()
        {
            a = 0;
        }

        public override void Enter()
        {
            _a = Convert.ToInt32(Console.ReadLine());
        }
    }
}
