using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game_BulidAlong
{
    public abstract class Character
    {
        //Constants 
        const int MIN_HEALTH = 0;

        //Properties 
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Energy { get; set; }
        public double CritChance { get; set; }

        //Methods
        public double Attack()
        {
            Random rnd = new Random();
            int spread = rnd.Next(-5, 6);
            int damage = this.AttackPower + spread;
            bool isCrit = IsCritical();
            return 0;
        }

        public bool IsCritical()
        {
            return true;
            

        }

    }   

}
