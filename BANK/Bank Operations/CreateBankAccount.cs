using System;

namespace Bank
{
    class CreateBankAccount : IBankCreate
    {
        Bank bank;
        Client client;

        public void Create()
        {
            String number = Bank.generateUniqueAccountNumber();
            BankAccount bankAccount = new BankAccount(number, "", client);
            client.addBankProduct(bankAccount);
            bank.bankProducts.Add(bankAccount);
        }

        public void SetOperationData(BankAccount account, Bank bank, Client client)
        {
            this.bank = bank;
            this.client = client;
        }

    }
}