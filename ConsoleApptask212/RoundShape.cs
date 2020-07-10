using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public abstract class RoundShape
    {
        private protected int x;
        private protected int y;
        private protected int radius;
        private protected int innerRadius;
        public int Radius
        {
            set
            {
                if (value < 0)
                {
                    x = 0;
                    y = 0;
                    radius = 0;
                }
                else
                    radius = value;
            }
            get { return radius; }
        }
        public int InnerRadius
        {
            set
            {
                if (value < 0)
                {
                    x = 0;
                    y = 0;
                    radius = 0;
                    innerRadius = 0;
                }
                else
                    innerRadius = value;
            }
            get { return innerRadius; }
        }
        public void EnterRoundShape(int a)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Radius = Convert.ToInt32(Console.ReadLine());
            //если для кольца
            if (a == 0)
            {
                InnerRadius = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double GetLength() => 2 * Math.PI * radius;
        public double GetArea() => Math.PI * radius * radius;
        public void DeleteRoundShape()
        {
            x = 0;
            y = 0;
            radius = 0;
            innerRadius = 0;
        }
    }
}
