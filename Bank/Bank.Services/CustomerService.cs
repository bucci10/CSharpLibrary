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
        public bool CreateCustomer(int CustomerID, string firstName, string lastName)
        {
            using (var ctx = new BankDBEntities())
            {
                var newCustomer =
                    new Customer
                    {
                        CustomerID = CustomerID,
                        FirstName = firstName,
                        LastName = lastName

                    };
                ctx.Customers.Add(newCustomer);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
