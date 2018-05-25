using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Client
    {
        private string name;
        private string surname;
        public BankAccount bankAccount;

        public Client(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void addBankAccount(BankAccount account) {
            this.bankAccount = account;
        }
    }
}
