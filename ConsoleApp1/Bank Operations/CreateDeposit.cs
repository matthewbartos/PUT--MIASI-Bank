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
        public void Create()
        {
            String number = Bank.generateUniqueAccountNumber();
            Deposit deposit = new Deposit(number, account);
            bank.bankProducts.Add(deposit);
        }

        public void SetOperationData(BankAccount account, Bank bank)
        {
            this.account = account;
            this.bank = bank;
        }
    }
}
