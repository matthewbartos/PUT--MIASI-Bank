using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public sealed class HistoryManager
    {
        private List<BankOperation> allBankOperations;

        private static readonly Lazy<HistoryManager> lazy =
            new Lazy<HistoryManager>(() => new HistoryManager());

        public static HistoryManager Instance { get { return lazy.Value; } }

        private HistoryManager()
        {
            this.allBankOperations = new List<BankOperation>();
        }

        public void addBankOperation(BankOperation bankOperation) {
            this.allBankOperations.Add(bankOperation);
        }
    }
}
