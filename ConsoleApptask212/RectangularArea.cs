using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public abstract class RectangularArea
    {
        private protected int a;
        private protected int b;
        public int A
        {
            set
            {
                if (value < 0)
                {
                    a = 0;
                    b = 0;
                }
                else
                    a = value;
            }
            get { return a; }
        }
        public int B
        {
            set
            {
                if (value < 0)
                {
                    a = 0;
                    b = 0;
                }
                else
                    b = value;
            }
            get { return b; }
        }
        public int Perimeter() => a + a + b + b;
        public int Square() => a * b;
        public void DeleteRectangularArea()
        {
            a = 0;
            b = 0;
        }
    }
}
