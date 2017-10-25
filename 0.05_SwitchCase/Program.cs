using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Kenn";

            switch (friend)
            {
                case "Ciprian":
                    Console.WriteLine("Hey Ciprian.");
                    break;
                case "John":
                    Console.WriteLine("John is pretty cool");
                    break;
                case "Kenn":
                    Console.WriteLine("Silent master Kenn...");
                    break;
                default:
                    Console.WriteLine("i don't know you.");
                    break;

            }
        }
    }
}
