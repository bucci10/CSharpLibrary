using Bank.Models;

namespace Bank.Services
{
    public partial class Deposits
    {
        public int DepositID { get; set; }
        public int TransactionID { get; set; }
        public decimal Amount { get; set; }

        public virtual Transaction Transactions { get; set; }
    }
}    
