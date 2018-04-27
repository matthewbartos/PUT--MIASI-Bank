namespace Bank
{
    public sealed class KIR
    {
        private List<Bank> allBank;

        private static readonly Lazy<KIR> lazy =
            new Lazy<KIR>(() => new KIR());

        public static KIR Instance => lazy.Value;

        private KIR()
        {
            allBank = new List<Bank>();
        }

        public void registerBank(Bank bank) {
            allBank.Add(bank);
        }

        private void accountExists(string bankIdSource, BankProduct bankProductSource)
        {
            //TODO - impelement
            //check bank id in allBank and find account
        }

        public Void transferMoney(String bankIdSource, String bankIdDestination, BankProduct bankProductSource, BankProduct bankProductDestination, DateTime date, Float value)
        {
            // check if destination bank exists & destination account exists
            // if no = return money to source account
            // if yes = perform money transfer
        }
    }
}