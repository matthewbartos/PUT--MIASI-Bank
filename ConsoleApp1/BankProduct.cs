using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankProduct
    {
        private string accountNumber;
        private float _balance;
        private List<BankOperation> history;
        private Percentage percentageMechanism;
        private DateTime establishDate;
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
            this.establishDate = DateTime.Now;
            this.history = new List<BankOperation>();
            this.accountNumber = number;
            this.balance = 0;
        }
        
        public float calculatePercentage() {
            return this.percentageMechanism.calculate(); 
        }

        public void setPercentageMechanism(Percentage mechanism) {
            this.percentageMechanism = mechanism;
        }

        public void addOperation(BankOperation bankOperation) {
            this.history.Add(bankOperation);
        }
    }
}
