using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface IBankCreate
    {
        void SetOperationData(Client client = null, BankAccount account=null);

        void Create();
    }
}
