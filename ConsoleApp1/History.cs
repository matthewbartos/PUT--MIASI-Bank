using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public sealed class HistoryManager
    {
        private List<IBankOperation> allBankOperations;

        private static readonly Lazy<HistoryManager> lazy =
            new Lazy<HistoryManager>(() => new HistoryManager());

        public static HistoryManager Instance { get { return lazy.Value; } }

        private HistoryManager()
        {
            this.allBankOperations = new List<IBankOperation>();
        }

        public void addBankOperation(IBankOperation bankOperation) {
            this.allBankOperations.Add(bankOperation);
        }
    }
}
