using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CrossbankTransferOperation : BankOperation
    {
        private string bankIdSource;
        private string bankIdDestination;

        public override void Execute()
        {
            bankProductDestination.balance += value;
        }

        public override void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.bankProductDestination = bankProductDestination;
            this.value = value;
        }

        public void SetBankData(string bankIdSource, string bankIdDestination)
        {
            this.bankIdSource = bankIdSource;
            this.bankIdDestination = bankIdDestination;
        }
    }
}