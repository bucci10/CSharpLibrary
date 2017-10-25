using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float myfloat = 3.14f;

            Console.WriteLine(myfloat);

            decimal myDecimal = 3.14159M;

            Console.WriteLine(myDecimal);

            double myDouble = 2.54;

            Console.WriteLine(myDouble);

            bool myTruth = true;


           
            string myName = "Ciprian";

          
            Console.WriteLine(myName);

            //Declaration
            //<type> <variableName> = <optional initializer>;
            int age;
            string country;
            // this is the proccess of initialization
            age = 27;

            Console.WriteLine(age);

            age = 28;

            Console.WriteLine(age);
            

            Console.Read();

        }
    }
}
