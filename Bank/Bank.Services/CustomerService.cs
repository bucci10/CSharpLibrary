using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
   public class CustomerService
    {
        public bool CreateCustomer(int customerID, string firstName, string lastName, int pin)
        {
            using (var ctx = new BankDBEntities())
            {
                var newCustomer =
                    new Customer
                    {
                        CustomerID = customerID,
                        FirstName = firstName,
                        LastName = lastName,
                        PIN = pin

                    };
                ctx.Customers.Add(newCustomer);
                return ctx.SaveChanges() == 1;
            }
        }

        public void CreateCustomer(Customer user)
        {
            throw new NotImplementedException();
        }
    }
}
