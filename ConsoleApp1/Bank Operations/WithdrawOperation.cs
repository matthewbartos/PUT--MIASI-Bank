using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class WithdrawOperation : IBankOperation
    {
        private BankAccount bankProductSource;
        
        private DateTime date;
        private float value;

        public void Execute()
        {
            if (bankProductSource.debet != null && value > bankProductSource.balance && value + bankProductSource.debet.balance <= bankProductSource.debet.maxDebet)
            {
                bankProductSource.balance = 0;
                bankProductSource.debet.balance += value - bankProductSource.balance;
            }
            else if (value <= bankProductSource.balance)
            {
                bankProductSource.balance -= value;
            }
        }

        public void SetOperationData(BankAccount bankProductSource, BankAccount bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.value = value;

        }
    }
}