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

            IBankOperation operation = new TransferOperation();
            operation.SetOperationData(source, destination, null, value);
            operation.Execute();
        
            HistoryManager.Instance.addBankOperation(operation);
        }

        public void paymentOnAccount(BankAccount destination, float value) {
            //destination.balance += value;
            IBankOperation operation = new TransferOperation();
            operation.SetOperationData(null, destination, null, value);
            operation.Execute();

            HistoryManager.Instance.addBankOperation(operation);
        }

        public void withdrawFromAccount(BankAccount source, float value) {
            IBankOperation operation = new WithdrawOperation();
            operation.SetOperationData(source, null, null, value);
            operation.Execute();
            HistoryManager.Instance.addBankOperation(operation);

            //if(source.debet != null && value > source.balance && value + source.debet.balance <= source.debet.maxDebet ) {
            //    source.balance = 0;
            //    source.debet.balance += value - source.balance;
            //} else if(value <= source.balance) {
            //    source.balance -= value;
            //}
        }

        public void paymentOnDeposit(Deposit depositAccount, float value) {
            //depositAccount.balance += value;
            //depositAccount.initialPayment = value;
            //depositAccount.bankAccountConnectedWithDeposit.balance -= value;
            IBankOperation operation = new DepositOperation();
            operation.SetOperationData(depositAccount, null, null, value);
            operation.Execute();
            HistoryManager.Instance.addBankOperation(operation);
        }

        public void closeDeposit(Deposit depositAccount) {
            //depositAccount.closeDeposit();
            //depositAccount = null;
            IBankOperation operation = new CloseDeposit();
            operation.SetOperationData(depositAccount, null, null, 0);
            operation.Execute();
            HistoryManager.Instance.addBankOperation(operation);

        }

        public void takeLoan(Credit creditAccount, float value) {
            creditAccount.balance -= value;
            creditAccount.bankAccountConnectedWithCredit.balance += value;
        }
    }
}
