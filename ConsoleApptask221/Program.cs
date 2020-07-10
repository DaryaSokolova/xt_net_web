using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Tom", 100, 0, 0, 1); //имя, здоровье, положение на Х и на У

            int value = 1;

            Policeman policeman = new Policeman(3, 3);
            Batman batman = new Batman(4, 4);
            Tree tree = new Tree(4, 2);
            Stone stone = new Stone(2, 4);

            Random rnd = new Random();
            int randomValue;
            int randomValue1;

            while ((player.HealthLine > 0))
            {
                Console.WriteLine("8 - вверх");
                Console.WriteLine("4 - влево");
                Console.WriteLine("2 - вниз");
                Console.WriteLine("6 - вправо");
                int temp = Convert.ToInt32(Console.ReadLine());
                switch (temp)
                {
                    case 8:
                        player.MoveToY(value);
                        break;
                    case 4:
                        player.MoveToX(-value);
                        break;
                    case 2:
                        player.MoveToY(-value);
                        break;
                    case 6:
                        player.MoveToX(value);
                        break;
                    default:
                        break;
                }

                randomValue = rnd.Next(-9, 9);
                randomValue1 = rnd.Next(-9, 9);

                Console.WriteLine("Your position: " + player.PositionX + "," + player.PositionY);
                Console.WriteLine("Policeman position:" + policeman.PositionX + "," + policeman.PositionY);
                Console.WriteLine("Batman position:" + batman.PositionX + "," + batman.PositionY);

                Medicine bonus = new Medicine(1, 1); //расположение статичного бонуса
                //если "наступить на бонус", то поднимается здоровье
                if ((bonus.PositionX == player.PositionX) && (bonus.PositionY == player.PositionY))
                {
                    player.PlusHealth(150);
                    Console.WriteLine("BONUS: + 150 health, " + player.Name + ", your health: " + player.HealthLine);
                }

                Medicine bonus1 = new Medicine(5, 3); //расположение статичного бонуса
                //если "наступить на бонус", то поднимается здоровье
                if ((bonus1.PositionX == player.PositionX) && (bonus1.PositionY == player.PositionY))
                {
                    player.PlusHealth(150);
                    Console.WriteLine("BONUS: + 150 health, " + player.Name + ", your health: " + player.HealthLine);
                }
                Serum serum = new Serum(2, 2);//расположение статичного бонуса
                //если "наступить на бонус", то поднимается скорость
                if ((serum.PositionX == player.PositionX) && (serum.PositionY == player.PositionY))
                {
                    player.NewSpeed(1);
                    value = player.speedNow;
                    Console.WriteLine("BONUS: + 1 speed, " + player.Name + ", your speed: " + player.speedNow);
                }

                //движения врагов случайны
                policeman.MoveToX(randomValue);
                policeman.MoveToY(randomValue);

                batman.MoveToX(randomValue1);
                batman.MoveToY(randomValue1);

                //если "наступает" на объект, то "откидывает" в сторону
                if ((tree.PositionX == player.PositionX) && (tree.PositionY == player.PositionY))
                {
                    player.MoveToX(-1);
                    player.MoveToY(-1);
                    Console.WriteLine("TREE: " + player.Name + ", your position: " + player.PositionX + "," + player.PositionY);
                }
                if ((tree.PositionX == policeman.PositionX) && (tree.PositionY == policeman.PositionY))
                {
                    policeman.MoveToX(-1);
                    policeman.MoveToY(-1);
                    Console.WriteLine("TREE: position: " + policeman.PositionX + "," + policeman.PositionY);
                }
                if ((tree.PositionX == batman.PositionX) && (tree.PositionY == batman.PositionY))
                {
                    batman.MoveToX(-1);
                    batman.MoveToY(-1);
                    Console.WriteLine("TREE: position: " + batman.PositionX + "," + batman.PositionY);
                }

                if ((stone.PositionX == player.PositionX) && (stone.PositionY == player.PositionY))
                {
                    player.MoveToX(2);
                    player.MoveToY(2);
                    Console.WriteLine("STONE: " + player.Name + ", your position: " + player.PositionX + "," + player.PositionY);
                }
                if ((stone.PositionX == policeman.PositionX) && (stone.PositionY == policeman.PositionY))
                {
                    policeman.MoveToX(2);
                    policeman.MoveToY(2);
                    Console.WriteLine("STONE: position: " + policeman.PositionX + "," + policeman.PositionY);
                }
                if ((stone.PositionX == batman.PositionX) && (stone.PositionY == batman.PositionY))
                {
                    batman.MoveToX(2);
                    batman.MoveToY(2);
                    Console.WriteLine("STONE: position: " + batman.PositionX + "," + batman.PositionY);
                }

                //если встретятся, то игрок получает урон
                if ((policeman.PositionX == player.PositionX) && (policeman.PositionY == player.PositionY))
                {
                    player.MinusHealth(100);
                    Console.WriteLine("DAMAGE");
                    Console.WriteLine("Your health: " + player.HealthLine);
                }

                if ((batman.PositionX == player.PositionX) && (batman.PositionY == player.PositionY))
                {
                    player.MinusHealth(100);
                    Console.WriteLine("DAMAGE");
                    Console.WriteLine("Your health: " + player.HealthLine);
                }

                //если дошел до точки, то победил
                if ((player.PositionX == 7) && (player.PositionY == 4))
                {
                    Console.WriteLine("you win");
                    break;
                }
            }
            Console.WriteLine("game over");
            Console.Read();
        }
    }
}
