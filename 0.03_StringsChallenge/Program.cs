using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // BRONZE CHALLENGE
            // Currency

            double cash = 438;
            Console.WriteLine("{0:C}", cash);

            //Percentage

            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);

            //Phone Number 
            int phoneNumber = 1234567890;
            string number1 = phoneNumber.ToString("(###) ### - ####");
            Console.WriteLine(number1);

            Console.WriteLine("{0: (###) ### - ####}", phoneNumber);

            Console.WriteLine(formatedphoneNumber);








            //SILVER CHALLENGE
            string potentialEmployerName = "John Joe";
            Console.WriteLine($"Salut, {potentialEmployerName}");
            Console.WriteLine($"Today is { DateTime.Now:d} I'm enjoying calls, and i think i'm enjoying C# the best.\n" +
                $"I'd like to get a job as a developer after i finish this course.");

            





        }
    }
}
