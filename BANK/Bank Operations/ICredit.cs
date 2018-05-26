using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface ICredit
    {
        void SetOperationData(BankAccount account = null, Bank bank = null, Client client = null);

        void Create(float balance);
    }
}
