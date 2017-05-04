using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class InsertCashTransaction : Transaction {

        public InsertCashTransaction(int transactionID, User transactionUser, int amount)
            : base(transactionID, transactionUser, amount){ }

        public override void Execute() {
            TransactionUser.Balance += Amount;
        }

        public override string ToString() {
            return ($"Transaction {TransactionID}: {Amount} was transfered to {TransactionUser}. Date: {Date}");
        }
    }
}
