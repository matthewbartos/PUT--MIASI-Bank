using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Deposit: BankProduct
    {
        private Interest interest;
        private BankAccount bankAccountConnectedWithDeposit;

        public Deposit(string number, BankAccount bankAccount) : base(number) {
            this.bankAccountConnectedWithDeposit = bankAccount;
        }
    }
}
