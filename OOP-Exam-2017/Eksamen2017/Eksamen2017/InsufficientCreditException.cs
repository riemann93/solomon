using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class InsufficientCreditException : Exception {

        public InsufficientCreditException() : base() { }

        public InsufficientCreditException(string message) : base(message) { }

        public InsufficientCreditException(User user, Product product) 
            : base("User " + user + " do not have sufficient funds to buy the product: " + product) {

        }

    }
}
