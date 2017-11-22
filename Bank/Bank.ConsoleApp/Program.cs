using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();

            customerService.CreateCustomer(1, "Ciprian", "Buciumean");
        }
    }
}
