using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Donut PaulDonut = new Donut();
            Donut KennDonut = new Donut();
            Donut JayDonut = new Donut();

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99M;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            JayDonut.Filling = "Creme";
            JayDonut.Price = 3.50M;
            JayDonut.Type = "AngelCreme";
            JayDonut.IsSpecial = true;

            Console.WriteLine(PaulDonut);
            Console.WriteLine(PaulDonut.Filling);

        }
    }
}
