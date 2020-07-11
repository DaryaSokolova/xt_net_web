using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    public abstract class Figure
    {
        public virtual double GetPerimeter()
        {
            return 0;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual string GetInfo()
        {
            return "";
        }

        public virtual string StringEnter()
        {
            return "";
        }

        public virtual void Delete()
        {

        }

        public virtual void Enter()
        {

        }
    }
}
