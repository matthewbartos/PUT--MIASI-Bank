using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankProduct: IBankProduct
    {
        private string accountNumber;
        private float _balance;
        private List<IBankOperation> history;
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
            this.history = new List<IBankOperation>();
            this.accountNumber = number;
            this.balance = 0;
            this.percentageMechanism = new LinearPercentage(2.0f);
   
        }

        public void calculatePercentage() { // timer bedzie wywolywac te funkcje co jakis czas
            var income = this.percentageMechanism.calculate(balance);
            balance += income;
        }

        public void setPercentageMechanism(Percentage mechanism) {
            if( mechanism != null)
            {
                this.percentageMechanism = mechanism;
            }
        }

        public void addOperation(IBankOperation bankOperation) {
            this.history.Add(bankOperation);
        }
       
    }
}
