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
            bankProductSource.balance -= value;
            bankProductDestination.balance += value;
        }

        public override void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.bankProductDestination = bankProductDestination;
            this.value = value;
        }
    }
}