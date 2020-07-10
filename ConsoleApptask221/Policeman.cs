using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    class Policeman : Field, IMovable
    {

        public Policeman(int valueX, int valueY)
        {
            _valueX = valueX;
            _valueY = valueY;
        }

        public int PositionX { get { return _valueX; } }
        public int PositionY { get { return _valueY; } }
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
    }
}
