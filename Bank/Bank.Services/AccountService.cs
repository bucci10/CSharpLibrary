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
                ctx.Accounts.Add(Account);
                return ctx.SaveChanges() == 1;

                    
            }
        }


        public Account GetAccountByID(int customerID, int accountID)
        {
            using (var ctx = new BankDBEntities())
            {
                return
                    ctx
                        .Accounts
                        .SingleOrDefault(e => e.CustomerID == customerID && e.AccountID == accountID);
            }
        }

        public List<Account> GetAccount(int customerID)
        {
            using (var ctx = new BankDBEntities())
            {
                return
                    ctx
                        .Accounts
                        .Where(e => e.CustomerID == customerID)
                        .ToList();
            }
        }

        public void CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
    
