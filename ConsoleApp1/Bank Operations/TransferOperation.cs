using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class TransferOperation : BankOperation
    {
       // private BankProduct bankProductSource;
       // private BankProduct bankProductDestination;
        //private float value;

        public override void Execute()
        {
            if(bankProductSource is BankAccount) {
                var source = bankProductSource as BankAccount;
                source.subtractMoney(value); 
            } else {
                bankProductSource.balance -= value;
            }

            if (bankProductDestination is BankAccount)
            {
                var destination = bankProductDestination as BankAccount;
                destination.addMoney(value);
            } else {
                bankProductDestination.balance += value;
            }
        }

        public override void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.bankProductDestination = bankProductDestination;
            this.value = value;
        }
    }
}