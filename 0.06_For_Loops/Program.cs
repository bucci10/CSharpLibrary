﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i = i + 2)
            {
                if (i == 10)
                {
                    Console.WriteLine("End of the line budddddy");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
           
    }
}