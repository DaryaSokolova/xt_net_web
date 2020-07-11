using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask212
{
    class Person
    {
        private string name;

        public Person(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return $"{name}";
        }
    }
}
