using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface IBankCreate
    {
        void SetOperationData(BankAccount account=null);

        void Create();
    }
}
