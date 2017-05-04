using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class Log {

        private string directory = @"..\..\LogFile.txt";

        public Log() { 
            if (!File.Exists(directory)) {
                FileStream stream = File.Create(directory);
                stream.Close();
            } else {
                Console.WriteLine("DONE");
                Console.ReadKey();
            }
        }

        public List<Transaction> GetTransactionForUser() {
            List<Transaction> userTransactions = new List<Transaction>();

            return userTransactions;
        }

        public int GetNextTransactionID() {

            List<string> transactions = new List<string>();
            transactions = ReadAllTransaction();
            string str;
            if((str = transactions.LastOrDefault()) != null){
                string[] arr = str.Split(' ');
                return Convert.ToInt32(arr[0]) + 1;
            } else {
                return 1;
            }

            
        }

        public void LogTransaction (Transaction trans){
            string transactionString = ($"{trans.TransactionID} {trans.TransactionUser} {trans.Date} {trans.Amount}");
            using (StreamWriter sw = File.AppendText(directory)) { sw.WriteLine(transactionString); }
        }     
        
        private List<string> ReadAllTransaction() {
            List<string> transactionStrings = new List<string>();
            StreamReader sr = new StreamReader(directory);
            string s;

            while ((s = sr.ReadLine()) != null) {
                transactionStrings.Add(s);
            }

            return transactionStrings; 
        }
    }
}
