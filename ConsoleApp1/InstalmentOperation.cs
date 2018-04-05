using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class InstalmentOperation : BankOperation
    {
        private BankProduct bankProductSource;
        private BankProduct bankProductDestination;
     //   private OperationType _type;
        private DateTime date;
        private float _value;

        public float value {
            get {
                return _value;
            }

            set {
                this._value = value;
            }
        }

        //public float type {
        //    get {
        //        return _type;
        //    }

        //    set {
        //        this._value = value;
        //    }
        //}

        public void makeTransfer() {
            bankProductSource.balance -= _value;
            bankProductDestination.balance += _value;
            this.date = DateTime.Now;
          //  this._type = OperationType.transfer;
        }

        public void deposit() {
            bankProductSource.balance += _value;
            this.date = DateTime.Now;
          //  this._type = OperationType.deposit;
        }

        public void withdraw() {
            bankProductSource.balance -= _value;
            this.date = DateTime.Now;
           // this._type = OperationType.withdraw;
        } 

        //public void calculatePercentage() {
        //    if(bankProductSource instanceOf )
        //    bankProductSource.calculatePercentage();
        //}      
        
        public void changePercentage() {

        }

        public void setUpInterest() {

        }

        public void breakInterest() {

        }

        public void credit() {

        }
        
    }
}
