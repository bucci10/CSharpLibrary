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
         
        //private BankDBEntities db = new BankDBEntities();

        //public Account MakeDeposit(Account model, int deposit)
        //{
        //    var entity =
        //        db
        //        .Accounts
        //           .Where(e => e.AccountID == model.AccountID && e.PIN == model.PIN)
        //           .Single();

        //    entity.Balance += deposit;
        //    UpdateTables(model, 1, deposit);
        //    db.SaveChanges();
        //    return entity;

        //}

        //public Account MakeWithdrawal(Account model, int withdrawal)
        //{
        //    var entity =
        //        db
        //        .Accounts
        //           .Where(e => e.AccountID == model.AccountID && e.PIN == model.PIN)
        //           .Single();

        //    entity.Balance -= withdrawal;
        //    UpdateTables(model, 2, withdrawal);
        //    db.SaveChanges();
        //    return entity;

        //}

        //public void UpdateTables(Account model, int type, int change)
        //{
        //    Transaction updateTransactions = new Transaction();
        //    updateTransactions.TransactionType = type;
        //    updateTransactions.AccountID = model.AccountID;
        //    db.Transactions.Add(updateTransactions);

        //    if (type == 1)
        //    {
        //        Deposits updateDeposits = new Deposits();
        //        updateDeposits.TransactionID = updateTransactions.TransactionID;
        //        updateDeposits.Amount = change;
        //        db.Deposits.Add(updateDeposits);
        //    }

        //    else
        //    {
        //        Withdrawls updateWithdrawals = new Withdrawls();
        //        updateWithdrawals.TransactionID = updateTransactions.TransactionID;
        //        updateWithdrawals.Amount = change;
        //        db.Withdrawls.Add(updateWithdrawals);
        //    }

        //    db.SaveChanges();
        //}
    }
}





    



