using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Triangle
    {
        private protected int a1;
        private protected int a2;
        private protected int a3;
        public Triangle(int A1, int A2, int A3)
        {
            a1 = A1;
            a2 = A2;
            a3 = A3;
        }
        public int A1
        {
            set
            {
                if (value < 0)
                {
                    a1 = 0;
                    a2 = 0;
                    a3 = 0;
                }
                else
                    a1 = value;
            }
            get { return a1; }
        }
        public int A2
        {
            set
            {
                if (value < 0)
                {
                    a1 = 0;
                    a2 = 0;
                    a3 = 0;
                }
                else
                    a2 = value;
            }
            get { return a2; }
        }
        public int A3
        {
            set
            {
                if (value < 0)
                {
                    a1 = 0;
                    a2 = 0;
                    a3 = 0;
                }
                else
                    a3 = value;
            }
            get { return a3; }
        }
        public void EnterTriangle()
        {
            A1 = Convert.ToInt32(Console.ReadLine());
            A2 = Convert.ToInt32(Console.ReadLine());
            A3 = Convert.ToInt32(Console.ReadLine());
        }
        public void DeleteTriangle()
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
        }
        public string GetInfoAboutTriangle()
        {
            return ($"ТРЕУГОЛЬНИК: Стoроны: {a1}, {a2}, {a3} Периметр: {Perimetr()} Площадь: {Square()}");
        }
        public string StringEnterTriangle()
        {
            return ("Введите параметры (a1 a2 a3):");
        }
        public int Perimetr() => a1 + a2 + a3;
        public double Square() => Math.Sqrt(Perimetr() / 2 * (Perimetr() / 2 - a1) * (Perimetr() / 2 - a2) * (Perimetr() / 2 - a3));
    }
}
