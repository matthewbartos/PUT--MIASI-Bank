using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{

    class CreditOperation : IBankOperation
    {
        BankAccount account;
        Bank bank;
        Client client;

        public void Execute()
        {
            String number = Bank.generateUniqueAccountNumber();
            Credit credit = new Credit(number, account);
            credit.balance = balance;
            client.addBankProduct(credit);
            bank.bankProducts.Add(credit);
        }

        public void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            this.account = account;
            this.bank = bank;
            this.client = client;
        }
    }
}