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
            creditAccount.bankAccountConnectedWithCredit.addMoney(value);
        }

        public void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            Credit credit = bankProductSource as Credit;
            credit.creditValue = value;
            this.creditAccount = credit;
            this.value = value;
        }
    }
}
