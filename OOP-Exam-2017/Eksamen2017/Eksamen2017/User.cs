using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class User : IComparable {
        public int UserID       { get { return userID; } }
        public string FirstName { get { return firstName; } }
        public string LastName  { get { return lastName; } }
        public string UserName  { get { return userName; } }
        public string Email     { get { return email; } }
        public int Balance {
            get { return balance; }
            set { balance = value; }
        }

        private int userID;
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private int balance;

        public User(int userID, string firstName, string lastName, string userName, string email, int balance) {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.email = email;
            this.balance = 0;
        }

        public int CompareTo(object obj) {
            return 1;
        }

        public override int GetHashCode() {
            return userID.GetHashCode();
        }

        public override string ToString() {
            return firstName + " " + lastName + ", Email: " + email;
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }
    }
}
