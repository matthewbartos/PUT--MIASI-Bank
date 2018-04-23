using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface IBankOperation
    {
        void SetOperationData(BankAccount bankProductSource = null, BankAccount bankProductDestination = null, DateTime? date = null, float value = 0);

        void Execute();
    }
}
