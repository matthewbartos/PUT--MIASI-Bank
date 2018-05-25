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
        public void ReturnFalseGivenValueOf1()
        {
            var result = true;

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
