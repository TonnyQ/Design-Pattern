using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Weapon
    {
        void UseWeapon();
    }

    public class Knift : Weapon
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("use knift");
        }
    }

    public class Axe : Weapon
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("use axe");
        }
    }
}
