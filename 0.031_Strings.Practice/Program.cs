using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._031_Strings.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string carMake;
            string carModel;
            string carClass;

            carMake = "Nissan";
            carModel = "GT-R";
            carClass = "racecar";



            Console.WriteLine("Hello i drive a " + carMake + "" + carModel + ". It is a " + carClass + ".");

            Console.WriteLine($"Hello, i drive a {carMake} {carModel}. It is a {carClass}.");
        }
    }
}
