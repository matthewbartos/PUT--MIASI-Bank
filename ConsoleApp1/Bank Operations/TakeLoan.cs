using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class TakeLoan : IBankOperation
    {
        Credit creditAccount;
        float value;

        public void Execute()
        {
            creditAccount.balance -= value;
            creditAccount.bankAccountConnectedWithCredit.balance += value;
        }

        public void SetOperationData(Credit bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.creditAccount = bankProductSource;
            this.value = value;
        }
    }
}
