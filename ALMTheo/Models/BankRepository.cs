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
            new Account{AccountID = 1, Money=25503, CustomerID= 1},
             new Account{AccountID = 2, Money=503, CustomerID= 1},
              new Account{AccountID = 3, Money=14525, CustomerID= 2},
             new Account{AccountID = 4, Money=2000340, CustomerID= 3},
        };


        public List<Customer> CustomerList = new List<Customer>
        {
            new Customer { CustomerID = 1, Name= "Tor-Leif"},
            new Customer{CustomerID = 2, Name= "Sigismund"},
            new Customer{CustomerID = 3, Name = "Margareta"}

        };

       

    }
}
