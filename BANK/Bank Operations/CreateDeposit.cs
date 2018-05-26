using System;
using System.Collections.Generic;
using Bank;
using System.Text;

namespace Bank
{
    class CreateDeposit : IBankCreate
    {
        BankAccount account;
        Bank bank;
        Client client;
        float balance;
        public void Create()
        {
            String number = Bank.generateUniqueAccountNumber();
            Deposit deposit = new Deposit(number, account);
            client.addBankProduct(deposit);
            bank.bankProducts.Add(deposit);
        }

        public void SetOperationData(BankAccount account, Bank bank, Client client)
        {
            this.account = account;
            this.bank = bank;
            this.client = client;
        }

        public void SetDepositValue(float value)
        {
            this.balance = value;
        }
    }
}
