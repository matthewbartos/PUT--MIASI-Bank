using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        // Unique bank id
        public String id;
        public List<Client> clients;
        public List<BankProduct> bankProducts;
        public HistoryManager historyManager;
        public Bank()
        {
            historyManager = new HistoryManager();
            clients = new List<Client>();
            bankProducts = new List<BankProduct>();
            id = generateUniqueBankId();
            KIR.Instance.registerBank(this);
        }

        private String generateUniqueBankId() {
            var chars = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            var stringChars = new char[35];
            var random = new Random();

            for (int i = 0; i<stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        public static String generateUniqueAccountNumber() {
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
            CreateBankAccount operation = new CreateBankAccount();
            operation.SetOperationData(null, this, client);
            operation.Create();
        }

        public void createBankCredit(BankAccount account, Client client) {
            //String number = generateUniqueAccountNumber();
            //Credit bankCredit = new Credit(number, account);
            //bankProducts.Add(bankCredit);
            IBankCreate operation = new CreateBankCredit();
            operation.SetOperationData(account, this, client);
            operation.Create();
        }

        public void createDeposit(BankAccount account, Client client) {
            //String number = generateUniqueAccountNumber();
            //Deposit deposit = new Deposit(number, account);
            //bankProducts.Add(deposit);
            IBankCreate operation = new CreateDeposit();
            operation.SetOperationData(account, this, client);
            operation.Create();
        }

        public void transferMoney(BankAccount source, BankAccount destination, float value) {

            IBankOperation operation = new TransferOperation();
            operation.SetOperationData(source, destination, null, value);
            operation.Execute();

            source.addOperation(operation);
            destination.addOperation(operation);
            historyManager.addBankOperation(operation);
        }

        public void paymentOnAccount(BankAccount destination, float value) {
            
            PaymentOnAccount operation = new PaymentOnAccount();
            operation.SetOperationValue(destination, new DateTime(), value);
            operation.Execute();

            destination.addOperation(operation);
            historyManager.addBankOperation(operation);
        }

        public void withdrawFromAccount(BankAccount source, float value) {
            IBankOperation operation = new WithdrawOperation();
            operation.SetOperationData(source, null, null, value);
            operation.Execute();
            source.addOperation(operation);
            historyManager.addBankOperation(operation);

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
            depositAccount.addOperation(operation);
            historyManager.addBankOperation(operation);
        }

        public void closeDeposit(Deposit depositAccount) {
            //depositAccount.closeDeposit();
            //depositAccount = null;
            IBankOperation operation = new CloseDeposit();
            operation.SetOperationData(depositAccount, null, null, 0);
            operation.Execute();
            depositAccount.addOperation(operation);
            historyManager.addBankOperation(operation);

        }

        public void takeLoan(Credit creditAccount, float value) {
            //creditAccount.balance -= value;
            //creditAccount.bankAccountConnectedWithCredit.balance += value;
            IBankOperation operation = new TakeLoan();
            operation.SetOperationData(creditAccount, null, null, value);
            operation.Execute();
            creditAccount.addOperation(operation);
            historyManager.addBankOperation(operation);
        }

        public void crossbankMoneyTransfer(BankAccount source, string destinationBankId, string destinationNumber, float value) {
            KIR.Instance.transferMoney(this, source, destinationBankId, destinationNumber, value);
        }
    }
}
