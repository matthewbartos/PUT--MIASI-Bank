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
            Assert.IsNull(client.getLastCreatedProductNumber());
            _bank.createBankAccount(client);
        }
    }
}
