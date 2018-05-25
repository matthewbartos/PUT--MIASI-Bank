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
        Client client;
        public void Create()
        {
            String number = Bank.generateUniqueAccountNumber();
            Credit bankCredit = new Credit(number, account);
            client.addBankProduct(bankCredit);
            bank.bankProducts.Add(bankCredit);
        }

        public void SetOperationData(BankAccount account, Bank bank, Client client)
        {
            this.account = account;
            this.bank = bank;
            this.client = client;
        }
    }
}
