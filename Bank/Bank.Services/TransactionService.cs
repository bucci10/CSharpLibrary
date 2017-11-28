using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
   public class TransactionService
    {
        public bool Transaction(int transactionID, int accountID, DateTime transactionDate, decimal transactionAmount, string transactionType)
        {
            using (var ctx = new BankDBEntities())
            {
                var newTransaction = new Transaction
                {
                    TransactionID = transactionID,
                    AccountID = accountID,
                    TransactionDate = transactionDate,
                    TransactionAmount = transactionAmount,
                    TransactionType = transactionType

                };
                ctx.Transactions.Add(newTransaction);

                return ctx.SaveChanges() == 1;
            }
        }


    }
}


