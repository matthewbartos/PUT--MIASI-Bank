using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class HistoryManager
    {
        private List<IBankOperation> allBankOperations;

        //private static readonly Lazy<HistoryManager> lazy =
        //    new Lazy<HistoryManager>(() => new HistoryManager());

        //public static HistoryManager Instance => lazy.Value;

        public HistoryManager()
        {
            this.allBankOperations = new List<IBankOperation>();
        }

        public void addBankOperation(IBankOperation bankOperation) {
            if(!allBankOperations.Contains(bankOperation)) {
                this.allBankOperations.Add(bankOperation);
            }
        }
    }
}
