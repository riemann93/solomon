using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class Stregsystem : IStregsystem{

        Log log;
        List<User> Users = new List<User>();
        List<Product> Products = new List<Product>();
        List<Transaction> Transactions = new List<Transaction>();

        public Stregsystem() {
            Console.WriteLine("DONE");
            Console.ReadKey();
            log = new Log();
        }

        public BuyTransaction BuyProduct(User user, Product product) {
            BuyTransaction trans = new BuyTransaction(log.GetNextTransactionID(), user, product);

            return trans;
        }

        //public InsertCashTransaction AddCreditsToAccount() {

        //}

        public void ExecuteTransaction() {

        }

        //public Product GetProductByID() {

        //}


        //public List<User> GetUsers(Func<User, bool> predicate) {
        //    //TODO
        //    List<User> u = new List<User>();
        //    return u;
        //}

        //public User GetUserByUsername(string username) {

        //}
        
        //public List<Transaction> GetTransactions(User user, int count) {

        //}

        //public List<Product> ActiveProducts() {

        //}

        //EVENT TIL AT NOTIFICERE BRUGER OM LAV BALANCE
    }
}
