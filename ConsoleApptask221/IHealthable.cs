using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    interface IHealthable
    {
        int HealthLine { get; }  // Текущая полоска здоровья
        void PlusHealth(int valueHealth);      // Повысить здоровье
        void MinusHealth(int valueHealth); // Понизить здоровье
    }
}
