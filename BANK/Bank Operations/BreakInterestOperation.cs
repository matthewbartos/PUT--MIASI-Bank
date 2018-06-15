using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class BreakInterestOperation : BankOperation
    {
        private BankProduct bankProductSource;
        private DateTime date;

		public override void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
		{
            this.bankProductSource = bankProductSource;
          //  this.date = date;
		}

		public override void Execute()
		{
            throw new NotImplementedException();
		}
	}
}