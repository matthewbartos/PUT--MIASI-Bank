using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface IBankOperation
    {
        void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0);
        void Execute();
    }
}
