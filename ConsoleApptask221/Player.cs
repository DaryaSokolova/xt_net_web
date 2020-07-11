using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    class Player : Field, IMovable
    {

        int healthLimit = 500;

        int _valueHealth;

        int _valueSpeed;

        public Player(int valueHealth, int valueX, int valueY, int valueSpeed)
            :base(valueX, valueY)
        {
            _valueHealth = valueHealth;
            _valueSpeed = valueSpeed;
        }

        public int HealthLine { get { return _valueHealth; } }

        public void PlusHealth(int valueHealth)
        {
            if (_valueHealth + valueHealth <= healthLimit)
            {
                _valueHealth += valueHealth;
            }
            else
            {
                _valueHealth = healthLimit;
            }
        }  //повысить здоровье

        public void MinusHealth(int valueHealth)
        {
            if (_valueHealth >= valueHealth)
            {
                _valueHealth -= valueHealth;
            }
        } //понизить здоровье

        public void MoveToX(int valueX)
        {
            if ((_valueX + valueX <= Width) && (_valueX + valueX >= 0))
            {
                _valueX += valueX;
            }
            else
            {
                if (_valueX + valueX > Width) //если превышает ширину, то упрется в правую стену
                    _valueX = Width;
                else _valueX = 0; // если меньше 0, то упрется в левую стену
            }
        } //движение по Х

        public void MoveToY(int valueY)
        {
            if ((_valueY + valueY <= Height) && (_valueY + valueY >= 0))
            {
                _valueY += valueY;
            }
            else
            {
                if (_valueY + valueY > Height) //если превышает ширину, то упрется в правую стену
                    _valueY = Height;
                else _valueY = 0; // если меньше 0, то упрется в левую стену
            }
        } //движение по У

        public int speedNow { get { return _valueSpeed; } }

        public void NewSpeed(int valueSpeed)
        {
            if (_valueSpeed + valueSpeed >= 0)
            {
                _valueSpeed += valueSpeed;
            }
        } //изменение скорости
    }
}
