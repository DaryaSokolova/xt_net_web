using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();
            Console.WriteLine("Enter Name: ");
            var str = Console.ReadLine();
            var type = (CellFieldsType)Enum.Parse(typeof(CellFieldsType), str);
            var cell = field.CreateCellFields(type);
            cell.Material();
        }
    }
    public class ActivePerson
    {
        public IMovable[] MovablePerson { get; }

        public ActivePerson(IMovable[] _person)
        {
            MovablePerson = _person;
        }
    }
    public class Field
    {
        public AbstractCellFields CreateCellFields(CellFieldsType type)
        {
            switch (type)
            {
                case CellFieldsType.Policeman:
                    return new Policeman(6, 2, "left");
                case CellFieldsType.Batman:
                    return new Batman(12, 4);
                case CellFieldsType.Player:
                    return new Player(4, 30);
                case CellFieldsType.Tree:
                    return new Tree();
                case CellFieldsType.Building:
                    return new Building();
                case CellFieldsType.Lamp:
                    return new Lamp();
                case CellFieldsType.Minions:
                    return new Minions();
                case CellFieldsType.Serum:
                    return new Serum(3);
                case CellFieldsType.Medicine:
                    return new Medicine(3);
                default: return null;
            }
        }
        public ActivePerson CreateSquad()
        {
            return new ActivePerson(new IMovable[]
            {
                new Batman(12, 4),
                new Policeman(6,2, "left"),
                new Player(4, 30)
            });
        }
    }
    public interface IShootable
    {
        int Damage { get; }
        void Shoot();
    }
    public interface IMovable
    {
        int Speed { get; }
        void Run();
    }
    public interface IDirection
    {
        string Direction { get; }
        void Motion();
    }
    public interface ISerializable
    {
        string Serialize();
    }
    public interface ILivable
    {
        int Health { get; }
        void MyHealth();
    }
    //абстрактная клетка
    public abstract class AbstractCellFields : ISerializable
    {
        public int[,] Map;
        //для положения объектов, как реализовать(?)
        public int x;
        public int y;

        protected AbstractCellFields()
        {

        }
        public abstract void Material();
        public string Serialize() => " This is cell fields of type " + GetType();
    }
    public abstract class ActiveEmenyObjects : AbstractCellFields, IShootable, IMovable
    {
        private int _damage;
        public virtual int Damage => _damage;

        private int _speed;
        public virtual int Speed => _speed;

        protected ActiveEmenyObjects(int damage, int speed)
        {
            _damage = damage;
            _speed = speed;
        }

        public sealed override void Material()
        {
            Console.WriteLine("Я ИЩУ ЗЛОДЕЯ");
        }

        public abstract void Shoot();
        public abstract void Run();
    }
    public class Policeman : ActiveEmenyObjects, IDirection
    {
        public Policeman(int damage, int speed, string direction) : base(damage, speed)
        {
            _direction = direction;
        }
        private string _direction;
        public virtual string Direction => _direction;
        public override void Shoot()
        {
            Console.WriteLine("Бьет слабо дубинкой с уроном: " + Damage);
        }
        public void Motion()
        {
            Console.WriteLine("Патрулирует улицы. Передвигается только " + Direction
                + ", пока не дойдет до препятствия, дойдя до препятствия, поворачивает обратно");
        }
        public override void Run()
        {
            Console.WriteLine("Двигаюсь со скоростью " + Speed);
        }
    }
    public class Batman : ActiveEmenyObjects
    {
        public Batman(int damage, int speed) : base(damage, speed)
        {
        }

        public override void Shoot()
        {
            Console.WriteLine("Больно бьет с уроном: " + Damage);
        }
        public override void Run()
        {
            Console.WriteLine("Бегает за злодеем со скоростью " + Speed);
        }
    }
    public class Player : AbstractCellFields, IMovable, ILivable
    {
        private int _speed;
        public virtual int Speed => _speed;
        private int _health;
        public virtual int Health => _health;

        public Player(int speed, int health)
        {
            _health = health;
            _speed = speed;
        }


        public override void Material()
        {
            Console.WriteLine("Я убегаю из Аркхема");
        }
        public void Run()
        {
            Console.WriteLine("Движусь со скоростью: " + Speed);
        }

        public void MyHealth()
        {
            Console.WriteLine("Моя жизнь =" + Health);
        }
    }
    public class Tree : AbstractCellFields
    {
        public override void Material()
        {
            Console.WriteLine("Я дерево");
        }
    }
    public class Building : AbstractCellFields
    {
        public override void Material()
        {
            Console.WriteLine("Я здание");
        }
    }
    public class Lamp : AbstractCellFields
    {
        public override void Material()
        {
            Console.WriteLine("Я фонарь");
        }
    }
    public class Minions : AbstractCellFields
    {
        public override void Material()
        {
            Console.WriteLine("Я приспешник, убиваю 1 врага на расстоянии 3 блоков.");
        }
    }
    public class Serum : AbstractCellFields, IMovable
    {
        private int _speed;
        public virtual int Speed => _speed;

        public Serum(int speed)
        {
            _speed = speed;
        }
        public override void Material()
        {
            Console.WriteLine("Я повышаю скорость героя");
        }
        public void Run()
        {
            Console.WriteLine("+" + Speed + "к скорости ан 10 секунд");
        }
    }
    public class Medicine : AbstractCellFields, ILivable
    {
        private int _health;
        public virtual int Health => _health;

        public Medicine(int speed)
        {
            _health = speed;
        }
        public override void Material()
        {
            Console.WriteLine("Я повышаю здоровье героя");
        }
        public void MyHealth()
        {
            Console.WriteLine("+" + Health + "к здоровью героя");
        }
    }
    public enum CellFieldsType
    {
        None,
        Player,

        Batman,
        Policeman,

        Tree,
        Building,
        Lamp,

        Minions,
        Serum,
        Medicine
    }
}