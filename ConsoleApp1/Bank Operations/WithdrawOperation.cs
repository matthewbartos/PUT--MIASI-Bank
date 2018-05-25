using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class WithdrawOperation : IBankOperation
    {
        private BankProduct bankProductSource;
        
        private DateTime date;
        private float value;

        public void Execute()
        {
            if (bankProductSource is BankAccount)
            {
                var source = bankProductSource as BankAccount;
                source.subtractMoney(value);
            }
            else
            {
                bankProductSource.balance -= value;
            }
        }

        public void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.value = value;

        }
    }
}