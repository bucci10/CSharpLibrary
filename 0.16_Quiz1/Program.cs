using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle(5, 5),
                new Triangle(2, 7),
                new Triangle(6, 9),
                new Triangle(5, 7),
                new Triangle(5, 3)
            };
      

            IEnumerable<Triangle> queryTwo = from t in triangles
                                             where t.TArea > 5.0
                                             orderby t.TArea ascending
                                             select t;
            foreach (Triangle s in queryTwo)
            {
                Console.WriteLine(s.TArea);
            }
        }   
    }   
}
