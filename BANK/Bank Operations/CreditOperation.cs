using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class CreditOperation : ICredit
    {
        BankAccount account;
        Bank bank;
        Client client;


        public void Create(float balance)
        {
            String number = Bank.generateUniqueAccountNumber();
            Credit credit = new Credit(number, account);
            credit.balance = balance;
            client.addBankProduct(credit);
            bank.bankProducts.Add(credit);
        }

        public void SetOperationData(BankAccount account, Bank bank, Client client)
        {
            this.account = account;
            this.bank = bank;
            this.client = client;
        }
    }
}