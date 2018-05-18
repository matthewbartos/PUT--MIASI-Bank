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

        public void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            if(bankProductSource is Deposit)
            {
                Deposit deposit = bankProductSource as Deposit;
                this.depositAccount = deposit;
            }
            
        }
    }
}
