using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Overloading
            // Create Player class with an Attack () methods
            // that accepts 3 different sets of paramaters 
            //
            // for Example: 
            // Attack(100)                          "Attacked for 100!"
            //Attack(100, "Weapon") -- >            "Attacked with Weapon for 100!"
            //Attack(100, "Weapon, #ofTimes) -->    "Attacked with Weapon for 100 #ofTimes, dealing tota lDamage!"

            Player me = new Player();
            me.Attack(2500);
          
        }

        


    }
}
