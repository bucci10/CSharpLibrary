using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArraysChallenge
{
    class Program
    {
        // Bronze Challenge

        static void Main(string[] args)
        {
            string[] fruit = new string[] { "Apples", "Cherries", "Watermelon" };
            foreach (string f in fruit)
            {

                Console.WriteLine(f);

            }
            //Silver Challenge 


            int[]  array1 = new int[] { 1, 2, 3, 4, 5 };
            int[]  array2 = new int[] { 10, 11, 12, 13, 14,};

            int[] sums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sums[i] = array1[i] + array2[i];

            }
            foreach (var numbers in sums)
            {
                Console.WriteLine(numbers);

            }

            //Gold Challenge

            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(50);

            }

            foreach  (int number in  randomNumbers)

            {
                Console.WriteLine(number);
            }


        }







    }
}
