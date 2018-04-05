using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Credit: BankProduct
    {
        private Interest interes;
        private BankAccount bankAccountConnectedWithCredit;
        public Credit(string number, BankAccount bankAccount) : base(number)
        {
            this.bankAccountConnectedWithCredit = bankAccount;
        }

        public void calculatePercentage() {
            // TODO Implement
        }

        public void setPercentageMechanism() {
            // TODO Implement
        }   
    }
}
