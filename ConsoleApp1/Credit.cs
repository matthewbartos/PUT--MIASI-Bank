﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Credit: BankProduct
    {
        private Interest interes;
        private BankAccount _bankAccountConnectedWithCredit;
        public Credit(string number, BankAccount bankAccount) : base(number)
        {
            this._bankAccountConnectedWithCredit = bankAccount;
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

        public void calculatePercentage() {
            
        }

        public void setPercentageMechanism() {
            // TODO Implement
        }   
    }
}
