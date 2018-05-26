using NUnit.Framework;

namespace Bank.Tests
{
    [TestFixture]
    public class BankTest
    {
        private readonly Bank _bank;

        public BankTest()
        {
            _bank = new Bank();
        }

        [Test]
        public void TwoBanksHasDifferentId()
        {
            var bank1 = new Bank();
            var bank2 = new Bank();

            Assert.AreNotEqual(bank1.id, bank2.id);
        }

        [Test]
        public void TwoÄccountsHasADifferentNumber()
        {
            var account1 = Bank.generateUniqueAccountNumber();
            var account2 = Bank.generateUniqueAccountNumber();

            Assert.AreNotEqual(account1, account2);
        }

        [Test]
        public void ClientCanCreateBankAccount()
        {
            var client = new Client("Name", "Surname");
            _bank.createBankAccount(client);

            Assert.IsNotNull(client.getLastCreatedProductNumber());
        }

        [Test]
        public void ClientPaymentOnAccount()
        {
            Client client = new Client("Name", "Surname");
            _bank.createBankAccount(client);
            string bankNumber = client.getLastCreatedProductNumber();
            BankAccount account = client.getBankProduct(bankNumber) as BankAccount;
            _bank.paymentOnAccount(account, 10000);
       
            Assert.AreEqual(account.balance, 10000);
        }

        public void CrossbankMoneyTransfer()
        {
            Bank bank1 = new Bank();
            Bank bank2 = new Bank();

            Client client1 = new Client("Name", "Surname");
            Client client2 = new Client("Name", "Surname");

            bank1.createBankAccount(client1);
            bank2.createBankAccount(client2);

            BankAccount account1 = client1.getBankProduct(Bank.generateUniqueAccountNumber()) as BankAccount;
            BankAccount account2 = client2.getBankProduct(Bank.generateUniqueAccountNumber()) as BankAccount;

            account1.balance = 1000;
            account2.balance = 0;

            bank1.crossbankMoneyTransfer(account1, bank2.id, account2.getAccountNumber(), 1000);
            KIR.Instance.performElixirSession();

            Assert.AreEqual(account1.balance, 0);
            Assert.AreEqual(account2.balance, 1000);
        }

        public void CreateDeposit()
        {
            Bank bank1 = new Bank();
            Client client1 = new Client("Name", "Surname");
            bank1.createBankAccount(client1);
            BankAccount account1 = client1.getBankProduct(Bank.generateUniqueAccountNumber()) as BankAccount;
            bank1.createDeposit(account1,client1);

            Assert.IsNotNull(client1.getLastCreatedProductNumber());
        }
    }
}
