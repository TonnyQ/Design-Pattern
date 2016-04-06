using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ch01 = new Player(new Axe());
            ch01.Speaking();
            ch01.Fighting();
            ch01.SetWeapon(new Knift());
            ch01.Fighting();

            Character ch02 = new NPC(new Knift());
            ch02.Speaking();
            ch02.Fighting();
            ch02.SetWeapon(new Axe());
            ch02.Fighting();

            Console.ReadKey();
        }
    }
}
