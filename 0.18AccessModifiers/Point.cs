using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18AccessModifiers
{
    class Point
    {   //Public vs Public difference
        public int x { get; set; }
        private int y { get; set; }
        
        public int PointMethod()
        {
            return this.x + this.y;
        }
    }
}
