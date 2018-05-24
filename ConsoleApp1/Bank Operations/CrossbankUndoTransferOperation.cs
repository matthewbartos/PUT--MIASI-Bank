using System;
namespace Bank
{
    public class CrossbankUndoTransferOperation: BankOperation
    {
        private string bankIdSource;

        public void Execute()
        {
            bankProductSource.balance += value;
        }

        public void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
        {
            this.bankProductSource = bankProductSource;
            this.bankProductDestination = null;
            this.value = value;
        }

        public void SetBankData(string bankIdSource)
        {
            this.bankIdSource = bankIdSource;
        }
    }
}
