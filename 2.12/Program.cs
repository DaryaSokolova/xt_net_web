using System;

namespace copy
{
    public abstract class RoundShape
    {
        public int x;
        public int y;
        private protected int radius;
        public int Radius
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Радиус не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    radius = value;
                }
            }
            get { return radius; }
        }
        private protected int innerRadius;
        public int InnerRadius
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    innerRadius = value;
                }
            }
            get { return innerRadius; }
        }
        public void GetInfo(int a)
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("r=");
            Radius = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("r'=");
                InnerRadius = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(radius);
        }
        public double GetLength() => 2 * Math.PI * radius;
        public double GetArea(int R) => Math.PI * R * R;
        public void DELETE1()
        {
            x = 0;
            y = 0;
            radius = 0;
            innerRadius = 0;
        }
    }
    class Round : RoundShape
    {
        public void GetInfo1()
        {
            Console.WriteLine($"КРУГ:");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius}");
            Console.WriteLine($"Площадь: {GetArea(radius)} Длина: {GetLength()}");
            Console.WriteLine();
        }
    }
    class Ring : RoundShape
    {
        public double GetAreaRing() => GetArea(radius) - GetArea(innerRadius);
        public double GetWidth() => radius - innerRadius;
        public void GetInfo2()
        {
            Console.WriteLine($"КОЛЬЦО:");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius} Внутренний радиус: {innerRadius}");
            Console.WriteLine($"Площадь: {GetAreaRing()}");
            Console.WriteLine($"Ширина: {GetWidth()}");
            Console.WriteLine();
        }
    }
    class Circle : RoundShape
    {
        public void GetInfo3()
        {
            Console.WriteLine("ОКРУЖНОСТЬ");
            Console.WriteLine($"Координаты: {x},{y} Радиус: {radius}");
            Console.WriteLine($"Длина: {GetLength()}");
            Console.WriteLine();
        }
    }
    public abstract class RectangularArea
    {
        private protected int a;
        public int A
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a = value;
                }
            }
            get { return a; }
        }
        private protected int b;
        public int B
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    b = value;
                }
            }
            get { return b; }
        }
        public int Perimeter(int a, int b) => a + a + b + b;
        public int Square(int a, int b) => a * b;
        public void DELETE2()
        {
            a = 0;
            b = 0;
        }
    }
    class Rectangle : RectangularArea
    {
        public void GetInfo4()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a=");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            B = Convert.ToInt32(Console.ReadLine());
        }
        public void GetInfo5()
        {
            Console.WriteLine("ПРЯМОУГОЛЬНИК");
            Console.WriteLine($"Длины: {a} и {b}");
            Console.WriteLine($"Периметр: {Perimeter(a, b)}");
            Console.WriteLine($"Площадь: {Square(a, b)}");
            Console.WriteLine();
        }
    }
    class Quadrate : RectangularArea
    {
        public void GetInfo6()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a=");
            A = Convert.ToInt32(Console.ReadLine());
        }
        public void GetInfo7()
        {
            Console.WriteLine("КВАДРАТ");
            Console.WriteLine($"Строна: {a}");
            Console.WriteLine($"Периметр: {Perimeter(a, a)}");
            Console.WriteLine($"Площадь: {Square(a, a)}");
            Console.WriteLine();
        }
    }
    class Triangle
    {
        private protected int a1;
        public int A1
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a1 = value;
                }
            }
            get { return a1; }
        }
        private protected int a2;
        public int A2
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    a2 = value;
                }
            }
            get { return a2; }
        }
        private protected int a3;
        public int A3
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть меньше 0, фигура создана с ошибкой");
                }
                else
                {
                    if ((a1 + a2 < a3) || (a2 + a3 < a1) || (a1 + a3 < a2))
                    {
                        a1 = 0;
                        a2 = 0;
                        Console.WriteLine("Такого треугольника не существует. Фигура создана неверно");
                    }
                    else
                    {
                        a3 = value;
                    }
                }
            }
            get { return a3; }
        }

        public void GetInfo8()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("a1=");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a2=");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a3=");
            A3 = Convert.ToInt32(Console.ReadLine());
        }
        public int P() => a1 + a2 + a3;
        public double Square() => Math.Sqrt(P() / 2 * (P() / 2 - a1) * (P() / 2 - a2) * (P() / 2 - a3));
        public void GetInfo9()
        {
            Console.WriteLine("ТРЕУГОЛЬНИК");
            Console.WriteLine($"Строны: {a1}, {a2}, {a3}");
            Console.WriteLine($"Периметр: {P()}");
            Console.WriteLine($"Площадь: {Square()}");
            Console.WriteLine();
        }
        public void DELETE3()
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
        }
    }
    class Line
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public void GetInfo10()
        {
            Console.WriteLine("Введите параметры: ");
            Console.Write("x1=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public double LengthLine() => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        public void GetInfo11()
        {
            Console.WriteLine("ЛИНИЯ");
            Console.WriteLine($"Координаты точек линии: ({x1},{y1}) и ({x2},{y2})");
            Console.WriteLine($"Длина: {LengthLine()}");
            Console.WriteLine();
        }
        public void DELETE4()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }
    }
    class Person
    {
        public string NAME;
        public void conclusion1()
        {
            Console.WriteLine($"{NAME}, выберите действие: ");
            Console.WriteLine("1 - Добавить фигуру");
            Console.WriteLine("2 - Вывести фигуры");
            Console.WriteLine("3 - Очистить холст");
            Console.WriteLine("4 - Сменить пользователя");
            Console.WriteLine("Иные цифры - Выход");
        }
        public void conclusion2()
        {
            Console.WriteLine($"{NAME}, выберите тип фигуры: ");
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Кольцо");
            Console.WriteLine("3 - Окружность");
            Console.WriteLine("4 - Прямоугольник ");
            Console.WriteLine("5 - Квадрат");
            Console.WriteLine("6 - Треугольник");
            Console.WriteLine("7 - Линия");
            Console.WriteLine("Иные цифры - Назад");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool fl = true;
            bool fl1 = true;

            int argRound = -1;
            int argRing = -1;
            int argCircle = -1;
            int argRectangle = -1;
            int argQuadrate = -1;
            int argTriangle = -1;
            int argLine = -1;

            Round round = new Round();
            Ring ring = new Ring();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Quadrate quadrate = new Quadrate();
            Triangle triangle = new Triangle();
            Line line = new Line();
            Person person = new Person();

            Console.WriteLine("Введите имя пользователя: ");
            person.NAME = Console.ReadLine();

            while (fl == true)
            {
                person.conclusion1();
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        fl1 = true;
                        while (fl1 == true)
                        {
                            person.conclusion2();

                            int selection1 = Convert.ToInt32(Console.ReadLine());
                            switch (selection1)
                            {
                                case 1:
                                    Console.WriteLine("Создание - Круг");
                                    round.GetInfo(-1);
                                    Console.WriteLine("Фигура создана!");
                                    argRound = 0;
                                    break;
                                case 2:
                                    Console.WriteLine("Создание - Кольцо");
                                    ring.GetInfo(0);
                                    Console.WriteLine("Фигура создана!");
                                    argRing = 0;
                                    break;
                                case 3:
                                    Console.WriteLine("Создание - Окружность");
                                    circle.GetInfo(-1);
                                    Console.WriteLine("Фигура создана!");
                                    argCircle = 0;
                                    break;
                                case 4:
                                    Console.WriteLine("Создание - Прямоугольник");
                                    rectangle.GetInfo4();
                                    Console.WriteLine("Фигура создана!");
                                    argRectangle = 0;
                                    break;
                                case 5:
                                    Console.WriteLine("Создание - Квадрат");
                                    quadrate.GetInfo6();
                                    Console.WriteLine("Фигура создана!");
                                    argQuadrate = 0;
                                    break;
                                case 6:
                                    Console.WriteLine("Создание - Треугольник");
                                    triangle.GetInfo8();
                                    Console.WriteLine("Фигура создана!");
                                    argTriangle = 0;
                                    break;
                                case 7:
                                    Console.WriteLine("Создание - Линия");
                                    line.GetInfo10();
                                    Console.WriteLine("Фигура создана!");
                                    argLine = 0;
                                    break;
                                default:
                                    Console.WriteLine("Вы вернулись к предыдущему выбору.");
                                    fl1 = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Фигуры: ");
                        if (argRound == 0) round.GetInfo1();
                        if (argRing == 0) ring.GetInfo2();
                        if (argCircle == 0) circle.GetInfo3();
                        if (argRectangle == 0) rectangle.GetInfo5();
                        if (argQuadrate == 0) quadrate.GetInfo7();
                        if (argTriangle == 0) triangle.GetInfo9();
                        if (argLine == 0) line.GetInfo11();
                        break;
                    case 3:
                        Console.WriteLine("Фигуры удалены!");
                        round.DELETE1();
                        argRound = -1;
                        ring.DELETE1();
                        argRing = -1;
                        circle.DELETE1();
                        argCircle = -1;
                        rectangle.DELETE2();
                        argRectangle = -1;
                        quadrate.DELETE2();
                        argQuadrate = -1;
                        triangle.DELETE3();
                        argTriangle = -1;
                        line.DELETE4();
                        argLine = -1;
                        break;
                    case 4:
                        Console.WriteLine("Введите имя пользователя: ");
                        person.NAME = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Вы вышли.");
                        fl = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}