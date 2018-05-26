using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class SetInterestOperation : BankOperation
    {
        private BankProduct bankProductSource;
        private DateTime date;

        public override void Execute()
        {
          
        }

        public override void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.bankProductSource = bankProductSource;
          //  this.date = date;
        }
    }
}