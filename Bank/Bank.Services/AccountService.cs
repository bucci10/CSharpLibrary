using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService
    {
        public bool CreateAccount(int accountID, int customerID, string accountType, decimal balance)
        {
            using (var ctx = new BankDBEntities())
            {
                var Account = new Account()
                {
                    AccountID = accountID,
                    CustomerID = customerID,
                    AccountType = accountType,
                    Balance = balance
                };
                ctx.account.Add(Account);
                return ctx.SaveChanges() == 1;

                    
            }
        }
    }
}

