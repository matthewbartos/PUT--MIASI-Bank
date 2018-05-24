using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class PaymentOnAccount : BankOperation
    {
        public override void Execute()
        {
            //System.Console.WriteLine(this.value);
            bankProductDestination.balance = bankProductDestination.balance + this.value;
          
        }

        public override void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.bankProductDestination = bankProductDestination;
            this.value = value;
        }

        public void SetOperationValue(BankProduct destination, DateTime? date = null, float value = 0) {
            this.bankProductDestination = destination;
            this.value = value;
        }
    }
}
