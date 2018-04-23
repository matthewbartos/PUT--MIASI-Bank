using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace Bank
{
    class CreateBankCredit : IBankCreate
    {
        BankAccount account;

        public void Create()
        {
            String number = generateUniqueAccountNumber();
            Credit bankCredit = new Credit(number, account);
            bankProducts.Add(bankCredit);
        }

        public void SetOperationData(BankAccount account)
        {
            this.account = account;
        }
    }
}
