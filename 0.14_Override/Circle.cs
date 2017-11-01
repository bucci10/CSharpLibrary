using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
   public abstract class Circle: Shape
    {   
        //Constructor 
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        //Constants

        public const double NUM_RADIUS = 3.14;

        //Properties 
        
            public int Radius { get; set; }

        //Methods 
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }
    }
}





