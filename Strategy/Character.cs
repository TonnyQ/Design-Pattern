using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Character
    {
        public Weapon weapon;
        public abstract void Fighting();
        public abstract void SetWeapon(Weapon p);

        public virtual void Speaking()
        {
            System.Console.WriteLine("hehe!");
        }
    }

    public class Player : Character
    {
        public Player(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override void Fighting()
        {
            weapon.UseWeapon();
        }

        public override void SetWeapon(Weapon p)
        {
            this.weapon = p;
        }

        public override void Speaking()
        {
            System.Console.WriteLine("funk C#!!!");
        }
    }

    public class NPC : Character
    {
        public NPC(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override void Fighting()
        {
            weapon.UseWeapon();
        }

        public override void SetWeapon(Weapon p)
        {
            this.weapon = p;
        }

        public override void Speaking()
        {
            System.Console.WriteLine("funk Java!!!");
        }
    }
}
