using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze

            Dictionary<int, string> academyAwards = new Dictionary<int, string>();
            academyAwards.Add(2000, "American Beauty");
            academyAwards.Add(2001, "Gladiator");
            academyAwards.Add(2002, "Beautiful Mind");
            academyAwards.Add(2003, "Chicago");
            academyAwards.Add(2004, "Lord of the Rings: The Return of the King");
            academyAwards.Add(2005, "Million Dollar Baby");

            foreach (var movie in academyAwards)
            {
                Console.WriteLine(movie.Key + " " + movie.Value);
            }



            //Silver

            Dictionary<string, string[]> awardNominees = new Dictionary<string, string[]>()
            {
                {"2006", new string[] {"Happy Feet", "Cars", "Monster House"} },
                {"2007", new string[] {"Ratatouille", "Persepolis", "Surf's Up"} },
                {"2008", new string[] {"Wall-E", "Bolt", "Kung Fu Panda"} },
                {"2009", new string[] {"Up", "Mr. Fantastic Fox",   "Coraline" } },
                {"2010", new string[] {"Toy Story 3", "How to Train Your Dragon", "The Illusionist"} },

            };

            foreach (var nominee in awardNominees)
            {
                Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value[0]}, {nominee.Value[1]}, {nominee.Value[2]}");
            }
        }




    }
}
