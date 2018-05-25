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
            client.addBankAccount(bankAccount);
            bank.bankProducts.Add(bankAccount);
        }

        public void SetOperationData(BankAccount account, Bank bank)
        {
            this.bank = bank;
        }

        public void SetClient(Client client) {
            this.client = client;
        }
    }
}