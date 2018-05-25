using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace Bank
{
    class CreateBankCredit : IBankCreate
    {
        Bank bank;
        BankAccount account;
        public void Create()
        {
            String number = Bank.generateUniqueAccountNumber();
            Credit bankCredit = new Credit(number, account);
            bank.bankProducts.Add(bankCredit);
        }

        public void SetOperationData(BankAccount account, Bank bank)
        {
            this.account = account;
            this.bank = bank;
        }
    }
}
