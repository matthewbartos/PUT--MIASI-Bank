using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Credit: BankProduct
    {

        public BankAccount _bankAccountConnectedWithCredit;
        public float creditValue;
        

        public Credit(string number, BankAccount bankAccount) : base(number)
        {
            this._bankAccountConnectedWithCredit = bankAccount;
            //this.creditValue = creditValue;
            //this.balance -= creditValue; 
            //this.bankAccountConnectedWithCredit.addMoney(creditValue);
            this.setPercentageMechanism(new LinearPercentage(5));
        }

        public BankAccount bankAccountConnectedWithCredit
        {
            get
            {
                return this._bankAccountConnectedWithCredit;
            }
            set
            {
                this._bankAccountConnectedWithCredit = value;
            }
        }

        
        public void payRate()
        {
            var additionalCost = Math.Abs(this.calculatePercentage());
            var totalCost = additionalCost + creditValue;

            if(bankAccountConnectedWithCredit.checkIfSubtractionPossible(totalCost)) {
                bankAccountConnectedWithCredit.subtractMoney(totalCost);
                this.closeCredit();
            }
           
            //spłacany(dla uproszczenia – w jednej racie równej wysokości kretytu + wysokości odsetek).
           
        }

        public void closeCredit()
        {
            this.balance = 0;
        }
    }
}
