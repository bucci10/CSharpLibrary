using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Objects_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Instantiation

            Netflix mindHunter = new Netflix();
            Netflix theOffice = new Netflix();
            Netflix planetEarth = new Netflix();


            // Set Object Values

            mindHunter.Name = "MindHunter";
            mindHunter.Genre = "Horror";
            mindHunter.Rating = 5;

            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 5;

            planetEarth.Name = "Planet Earth";
            planetEarth.Genre = "Documentary";
            planetEarth.Rating = 3;

            //Calling the methods


            theOffice.GetSuggestion();

            mindHunter.GetSuggestion();

            planetEarth.GetSuggestion();

            

            //Create a list of netflix Objects// Gold Challenge

            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(theOffice);
            favoriteShows.Add(mindHunter);
            favoriteShows.Add(planetEarth);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
            }   
            {

            }

            Console.ReadLine();
        }


    }
}
