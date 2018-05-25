using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class DebtOperation : BankOperation
    {
        private BankProduct bankProductSource;
        private DateTime date;

		public override void Execute()
		{
            throw new NotImplementedException();
		}

		public override void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
		{
            throw new NotImplementedException();
		}
	}
}
