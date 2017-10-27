using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone("Iphone", "7");

            Console.WriteLine($"I own an {phone.PhoneMake} {phone.PhoneModel}");
        }
    }
}
