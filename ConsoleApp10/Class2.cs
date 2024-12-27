using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp10.Class1;

namespace ConsoleApp10
{
    internal class Class2
    {
        class Program
        {
            static void Main()
            {
                Soldier soldier = new Soldier("Соколов", 185, 65);
                GraduateSoldier graduateSoldier = new GraduateSoldier("Соколов", 175, 70, "высшее");

                soldier.DisplayInfo();
                graduateSoldier.DisplayInfo();
            }
        }

    }
}
