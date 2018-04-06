using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        private List<Client> clients;
        private List<BankProduct> bankProducts;

        public String generateUniqueAccountNumber() {
            var chars = "0123456789";
            var stringChars = new char[9];
            var random = new Random();

            for (int i = 0; i<stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        public void createBankAccount(Client client) {
            String number = generateUniqueAccountNumber();
            BankAccount bankAccount = new BankAccount(number, "", client);
            bankProducts.Add(bankAccount);
        }

        public void createBankCredit(BankAccount account) {
            String number = generateUniqueAccountNumber();
            Credit bankCredit = new Credit(number, account);
            bankProducts.Add(bankCredit);
        }

        public void createDeposit(BankAccount account) {
            String number = generateUniqueAccountNumber();
            Deposit deposit = new Deposit(number, account);
            bankProducts.Add(deposit);
        }

        public void transferMoney(BankAccount source, BankAccount destination, float value) {
            source.balance -= value;
            destination.balance += value;
            HistoryManager.Instance.addBankOperation(new TransferOperation());
        }

        public void paymentOnAccount(BankAccount destination, float value) {
            destination.balance += value;
        }

        public void withdrawFromAccount(BankAccount source, float value) {
            if(source.debet != null && value > source.balance && value + source.debet.balance <= source.debet.maxDebet ) {
                source.balance = 0;
                source.debet.balance += value - source.balance;
            } else if(value <= source.balance) {
                source.balance -= value;
            }
        }

        public void paymentOnDeposit(Deposit depositAccount, float value) {
            depositAccount.balance += value;
            depositAccount.initialPayment = value;
            depositAccount.bankAccountConnectedWithDeposit.balance -= value;
        }

        public void closeDeposit(Deposit depositAccount) {
            depositAccount.closeDeposit();
            depositAccount = null; // czy to usuwa? chyba tak
        }

        public void takeLoan(Credit creditAccount, float value) {
            creditAccount.balance -= value;
            creditAccount.bankAccountConnectedWithCredit.balance += value;
        }
    }
}
