using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    abstract class Transaction {
        public int TransactionID { get { return transactionID; } }
        public User TransactionUser { get { return transactionUser; } }
        public DateTime Date { get { return date; } }
        public int Amount { get { return amount; } }

        private int transactionID;
        private User transactionUser;
        private DateTime date;
        private int amount;

        public Transaction(int transactionID, User transactionUser, int amount) {
            this.transactionUser = transactionUser;
            this.amount = amount;
            this.transactionID = transactionID;
            date = DateTime.Now;
        
        }

        public virtual void Execute() {

        }
        
        public override string ToString() {
            return "Transaction ID" + TransactionID + "Transaction User: " + TransactionUser.ToString() + "Transaction Amount: " + Amount + "Transaction time: " + Date;
        }
    }
}
