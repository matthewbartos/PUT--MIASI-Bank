using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Deposit: BankProduct
    {
        private Interest interest;
        private BankAccount _bankAccountConnectedWithDeposit;

        public Deposit(string number, BankAccount bankAccount) : base(number) {
            this._bankAccountConnectedWithDeposit = bankAccount;
        }

        public BankAccount bankAccountConnectedWithDeposit {
            get {
                return this._bankAccountConnectedWithDeposit;
            } 
            set {
                this._bankAccountConnectedWithDeposit = value;
            }
        }

    }
}
