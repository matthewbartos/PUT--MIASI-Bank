using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class DepositOperation : IBankOperation
    {
     
        Deposit depositAccount;
        float value;

        public void Execute()
        {
            depositAccount.balance += value;
            depositAccount.initialPayment = value;
            depositAccount.bankAccountConnectedWithDeposit.balance -= value;

        }

        public void SetOperationData(Deposit bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.depositAccount = bankProductSource;
            this.value = value;
        }
    }
}
