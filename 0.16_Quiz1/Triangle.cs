using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Quiz1
{
     class Triangle : Shape

    {
        //Constructor 
        public Triangle(int tBase, int tHeight)
        {
            this.TBase =tBase;
            this.THeight = tHeight;
            this.TArea = this.Area();
        }

        // Properties
        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }


        //Methods

        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2.0;
            return this.TArea;
        }
    }
}
