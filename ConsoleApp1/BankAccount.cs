using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount: BankProduct
    {
        private string name;
        private Client client;
        private DateTime establishDate;


        public BankAccount(string number): base(number)
        {
            
        }
    }
}
