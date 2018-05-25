using System;
namespace Bank
{
    public class CrossbankUndoTransferOperation: BankOperation
    {
        private string bankIdSource;

        public override void Execute()
        {
            if (bankProductSource is BankAccount)
            {
                var source = bankProductSource as BankAccount;
                source.addMoney(value);
            }
            else
            {
                bankProductSource.balance += value;
            }
        }

        public override void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
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
