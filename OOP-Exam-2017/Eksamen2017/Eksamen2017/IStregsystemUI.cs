using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    interface IStregsystemUI {
        /*
        void DisplayUserNotFound(string username);
        void DisplayProductNotFound(string product);
        void DisplayUserInfo(User user);
        void DisplayTooManyArgumentsError(string command);
        void DisplayAdminCommandNotFoundMessage(string adminCommand);
        void DisplayUserBuysProduct(BuyTransaction transaction);
        void DisplayUserBuysProduct(int count, BuyTransaction transaction);
        
        void DisplayInsufficientCash(User user, Product product);
        void DisplayGeneralError(string errorString);
        event StregsystemEvent CommandEntered; 
        */
        void Close();
        void Start();
    }
}
