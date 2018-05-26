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

        public void Cross()
        {

        }
    }
}
