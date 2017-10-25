using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge
            int myint = 10;
            string mystring;
            bool mybool = true;
            float myfloat = 3.8f;
            double mydouble = 20;
            decimal mydecimal = 1.123M;

            
            Console.WriteLine(myint);

            // Silver Challange

           mystring = $"{myint} {mybool} {mydouble} {mydecimal}";

            Console.WriteLine(mystring);

            // Gold Challange

            string myYear = "1989";

            Console.WriteLine($"I was born in { Int32.Parse(myYear)}");

            string birthYear = "1980";
            int year = Convert.ToInt32(birthYear);
            Console.WriteLine("I was born in " + year);

            string age = "30";
            int numAge = Convert.ToInt32(age);
            numAge = numAge + 1;
            Console.WriteLine(numAge);

            Console.Read();

           
            




        }
    }
}
