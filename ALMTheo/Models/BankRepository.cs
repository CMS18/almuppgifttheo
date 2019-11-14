using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ALMTheo.Models
{
    public class BankRepository
    {

       
        public List<Account> AccountsList = new List<Account>
        {
            new Account{AccountID = 1, Money=100, CustomerID= 1},
            new Account{AccountID = 2, Money=503, CustomerID= 1},
            new Account{AccountID = 3, Money=14525, CustomerID= 2},
            new Account{AccountID = 4, Money=2000340, CustomerID= 3},
        };


        public List<Customer> CustomersList = new List<Customer>
        {
            new Customer{CustomerID = 1, Name= "Tor-Leif"},
            new Customer{CustomerID = 2, Name= "Sigismund"},
            new Customer{CustomerID = 3, Name= "Margareta"}

        };

        public bool TakeMoney(decimal money, int account)
        {
          
            var currAccount = AccountsList.SingleOrDefault(m => m.AccountID == account);
            if(currAccount == null)
            {
                return false;
            }
            else if (currAccount.Money - money < 0 ) { return false; }
            else { currAccount.Money -= money; return true; }

        }
        public bool PutMoney(decimal money, int account)
        {
            var currAccount = AccountsList.SingleOrDefault(m => m.AccountID == account);
            if (currAccount != null)
            {
                currAccount.Money += money; return true;
            }
            else return false;
        }
        
        public Account GetAccount(int id)
        {
            var account = AccountsList.SingleOrDefault(m => m.AccountID == id);
            return account;
        }

        public bool Transfer(int accountFrom, int accountTo, decimal money)
        {
            var accFrom = AccountsList.SingleOrDefault(m => m.AccountID == accountFrom);
            var accTo = AccountsList.SingleOrDefault(m => m.AccountID == accountTo);



            if (accFrom == null || accTo == null || money < 0 || accFrom.Money < money)
            {
                return false;
            }

            accFrom.Money -= money;
            accTo.Money += money;

            return true;
        }

    }
}
