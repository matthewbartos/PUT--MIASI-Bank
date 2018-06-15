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
            Deposit deposit = new Deposit(number, account, balance);
            TransferOperation transfer = new TransferOperation();
            transfer.SetOperationData(account, deposit, new DateTime(), balance);
            transfer.Execute();


            client.addBankProduct(deposit);
            bank.bankProducts.Add(deposit);
            bank.historyManager.addBankOperation(transfer);


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
