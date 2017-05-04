using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class BuyTransaction : Transaction {
        public Product Product { get { return product; } }
        public int ProductAmount { get { return productAmount; } }

        private Product product;
        private int productAmount;

        public BuyTransaction(int transactionID, User transactionUser, Product product) 
        : base(transactionID, transactionUser, product.Price) {
            this.product = product;
            productAmount = product.Price;
        }

        public override void Execute() {
            if (TransactionUser.Balance < productAmount) {
                throw new InsufficientCreditException(TransactionUser, Product);
            } else {
                TransactionUser.Balance -= Amount;
            }
        }

        public override string ToString() {
            return ($"Transaction {TransactionID}:  User {TransactionUser} bought {Product} for {Amount}. Date: {Date}");
        }
    }
}
