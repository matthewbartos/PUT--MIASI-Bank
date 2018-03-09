using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount: BankProduct
    {
        private string name;
        private float balance;
        private List<Client> clients;

        public BankAccount(string number): base(number)
        {
            
        }
    }
}
