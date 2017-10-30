using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character myName = new Character();
            Player newHero = new Player();
            Enemy jenn = new Enemy();

            Console.WriteLine("Hello, wonderer...\n" +
                "What be thy name?");
            newHero.Name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"\n\n Nice to meet you, {newHero.Name}.");
            Console.ReadLine();
            Console.WriteLine($"Where do you come from, friend?)\n" +
                "1:Horse Mange \n" +
                "2:Troll Call \n:" +
                "3:Knight Templar\n" +
                "4:umonnn\n" +
                "5:Dogman");
            Player.Specialization = int.Parse(Console.ReadLine());

        }
    }
}
