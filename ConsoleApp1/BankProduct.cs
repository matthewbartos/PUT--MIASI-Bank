using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankProduct
    {
        private string accountNumber;
        private float _balance;

        public float balance {
            get {
                return this._balance;
            }

            set {
                this._balance = balance;
            }
        }


        public BankProduct(string number)
        {
            this.accountNumber = number;
            this.balance = 0;
        }
        
        public void calculatePercentage() {
            // nop
        }

        public void setPercentageMechanism() {
            // nop
        }
    }
}
