using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Credit: BankProduct
    {

        public BankAccount _bankAccountConnectedWithCredit;
        //private float creditRate;
        public float creditValue;
        

        public Credit(string number, BankAccount bankAccount, float creditValue) : base(number)
        {
            this._bankAccountConnectedWithCredit = bankAccount;
            this.creditValue = creditValue;
            this.balance += creditValue; //to traktujemy jako kase na miniusie
            this.bankAccountConnectedWithCredit.addMoney(creditValue);
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

        
        public void payRate(BankAccount bA, float rate)
        {
            bA.balance = bA.balance + rate;
            if (bA.balance == rate)
            {
                closeCredit();
            }
           
            //spłacany(dla uproszczenia – w jednej racie równej wysokości kretytu + wysokości odsetek).
           
        }

        public void closeCredit()
        {
            this._bankAccountConnectedWithCredit.balance = 0;
        }
    }
}
