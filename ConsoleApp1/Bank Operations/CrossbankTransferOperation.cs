using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CrossbankTransferOperation : IBankOperation
    {
        private string bankIdSource;
        private string bankIdDestination;
        private BankProduct bankProductSource;
        private BankProduct bankProductDestination;
        private float value;
        private DateTime date;

        public void Execute()
        {
            bankProductSource.balance -= value;
            KIR.Instance.transferMoney(bankIdSource, bankIdDestination, bankProductSource, bankProductDestination,
                date, value);
        }

        public void SetOperationData(BankProduct bankProductSource, BankProduct bankProductDestination, DateTime? date, float value)
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