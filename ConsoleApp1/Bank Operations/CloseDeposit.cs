using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CloseDeposit : IBankOperation
    {
        Deposit depositAccount;
        public void Execute()
        {
            depositAccount.closeDeposit();
            depositAccount = null;
        }

        public void SetOperationData(Deposit bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.depositAccount = bankProductSource;
        }
    }
}
