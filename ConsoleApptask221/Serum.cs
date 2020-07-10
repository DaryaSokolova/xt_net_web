using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    class Serum : Field
    {
        public Serum(int valueX, int valueY)
        {
            _valueX = valueX;
            _valueY = valueY;
        }
        public int PositionX { get { return _valueX; } }
        public int PositionY { get { return _valueY; } }
    }
}
