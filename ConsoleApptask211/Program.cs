using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask211
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringClass newString = new MyStringClass("Привет!");
            MyStringClass newString1 = new MyStringClass("Привет, как дела?");

            Console.WriteLine(MyStringClass.Compare(newString, newString1));
            Console.WriteLine(newString1.Concat(newString1).ToArray());
            Console.WriteLine(newString.IndexOf('к'));
            Console.WriteLine(newString.LastIndexOf('!'));
            Console.WriteLine(newString.Substring(1, 3).ToArray());
            Console.WriteLine(newString.Remove(1, 3).ToArray());

        }
    }
}
