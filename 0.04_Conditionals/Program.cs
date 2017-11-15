using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("On a scale of 1-5, how do you feel about SkyDiving? ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("Grow a pair.");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("It could be worse.");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Get well Soon!");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("JUMPPPPP!");
            }
            else
            {
                Console.WriteLine("Do it!!!");
            }

            //Verbal Challenge
            //Boolean 

            Console.WriteLine("How much money is in your bank account?");
            int bankAccount = Convert.ToInt32(Console.ReadLine());

            if (bankAccount > 10000)
            {
                Console.WriteLine("Wooooooo! You're rich???");
            }
            else
            {
                Console.WriteLine("That sucks!");
            }

        }
       


    }
}

                         

