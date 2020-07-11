using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fl = true;

            Round round = new Round(0, 0, 0);
            Ring ring = new Ring(0, 0, 0, 0);
            Rectangle rectangle = new Rectangle(0, 0);
            Quadrate quadrate = new Quadrate(0);
            Triangle triangle = new Triangle(0, 0, 0);
            Line line = new Line(0, 0, 0, 0);

            Console.WriteLine("Введите имя пользователя: ");
            string Name = Console.ReadLine();
            Person person = new Person(Name);

            while (fl == true)
            {
                Console.WriteLine(person.GetName() + ", выберите действие: ");
                Console.WriteLine("1 - Добавить фигуру");
                Console.WriteLine("2 - Вывести фигуры");
                Console.WriteLine("3 - Очистить холст");
                Console.WriteLine("4 - Сменить пользователя");
                Console.WriteLine("Иные цифры - Выход");

                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        bool fl1 = true;
                        while (fl1 == true)
                        {
                            Console.WriteLine(person.GetName() + ", выберите тип фигуры: ");
                            Console.WriteLine("1 - Круг");
                            Console.WriteLine("2 - Кольцо");
                            Console.WriteLine("4 - Прямоугольник ");
                            Console.WriteLine("5 - Квадрат");
                            Console.WriteLine("6 - Треугольник");
                            Console.WriteLine("7 - Линия");
                            Console.WriteLine("Иные цифры - Назад");

                            int selection1 = Convert.ToInt32(Console.ReadLine());
                            switch (selection1)
                            {
                                case 1:
                                    Console.WriteLine("Создание - Круг");
                                    Console.WriteLine(round.StringEnter());
                                    round.Enter();
                                    Console.WriteLine("Фигура создана!");
                                    break;
                                case 2:
                                    Console.WriteLine("Создание - Кольцо");
                                    Console.WriteLine(ring.StringEnter());
                                    ring.Enter();
                                    Console.WriteLine("Фигура создана!");
                                    break;
                                case 4:
                                    Console.WriteLine("Создание - Прямоугольник");
                                    Console.WriteLine(rectangle.StringEnter());
                                    rectangle.Enter();
                                    Console.WriteLine("Фигура создана!");
                                    break;
                                case 5:
                                    Console.WriteLine("Создание - Квадрат");
                                    Console.WriteLine(quadrate.StringEnter());
                                    quadrate.Enter();
                                    Console.WriteLine("Фигура создана!");
                                    break;
                                case 6:
                                    Console.WriteLine("Создание - Треугольник");
                                    Console.WriteLine(triangle.StringEnter());
                                    triangle.Enter();
                                    Console.WriteLine("Фигура создана!");
                                    break;
                                case 7:
                                    Console.WriteLine("Создание - Линия");
                                    Console.WriteLine(line.StringEnter());
                                    line.Enter();
                                    Console.WriteLine("Фигура создана!");
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

                        Console.WriteLine(round.GetInfo());
                        Console.WriteLine(ring.GetInfo());
                        Console.WriteLine(rectangle.GetInfo());
                        Console.WriteLine(quadrate.GetInfo());
                        Console.WriteLine(triangle.GetInfo());
                        Console.WriteLine(line.GetInfo());
                        break;
                    case 3:
                        Console.WriteLine("Фигуры удалены!");

                        round.Delete();
                        ring.Delete();
                        rectangle.Delete();
                        quadrate.Delete();
                        triangle.Delete();
                        line.Delete();
                        break;
                    case 4:
                        Console.WriteLine("Введите имя пользователя: ");
                        Name = Console.ReadLine();
                        person = new Person(Name);
                        break;
                    default:
                        Console.WriteLine("Вы вышли.");
                        fl = false;
                        break;
                }
            }
        }
    }
}
