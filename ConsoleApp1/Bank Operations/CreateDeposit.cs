using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CreateDeposit : IBankCreate
    {
        BankAccount account;
        public void Create()
        {
            String number = generateUniqueAccountNumber();
            Deposit deposit = new Deposit(number, account);
            //bankProducts.Add(deposit);
        }

        public void SetOperationData(BankAccount account)
        {
            this.account = account;
        }
    }
}
