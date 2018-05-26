using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Deposit: BankProduct
    {
        //private BankAccount clientAccount;
        private BankAccount _bankAccountConnectedWithDeposit;
        private float income;
        public float initialPayment;
        private DateTime expirationDate;

        public int months {
            get {
                return months;
            }

            set {
                this.expirationDate = expirationDate.AddMonths(value);
            }
        }

        public Deposit(string number, BankAccount bankAccount) : base(number) {
            this.income = 0;
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

        public void closeDeposit() {
            if (DateTime.Now.CompareTo(expirationDate) < 0) { // zamykamy przed czasem
                this.bankAccountConnectedWithDeposit.balance += initialPayment;
            } else {
                this.bankAccountConnectedWithDeposit.balance += initialPayment + income;
            }
            this.initialPayment = 0;
            this.income = 0;
        } 
    }
}
