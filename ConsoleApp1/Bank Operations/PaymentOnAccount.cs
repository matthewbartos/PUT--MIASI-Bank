using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class PaymentOnAccount : IBankOperation
    {
        private BankProduct bankProductDestination;
        private float value;

        public void Execute()
        {
            bankProductDestination.balance += value;
        }

        public void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.bankProductDestination = bankProductDestination;
            this.value = value;
        }
    }
}
