using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bank bankMillenium = new Bank();
            Bank bankBGZBNPParibas = new Bank();
            Client client1 = new Client("Pawel", "Szudrowicz");
            Client client3 = new Client("Paulinson", "Paulinson");
            Client client2 = new Client("Mateusz", "Bartos");
            bankMillenium.createBankAccount(client1);
            string client1BankNumber = client1.getLastCreatedProductNumber();
            Console.WriteLine(client1BankNumber);
            BankAccount account1 = client1.getBankProduct(client1BankNumber) as BankAccount;
            bankMillenium.createBankAccount(client3);
            string client3BankNumber = client3.getLastCreatedProductNumber();
            Console.WriteLine(client3BankNumber);
            BankAccount account3 = client3.getBankProduct(client3BankNumber) as BankAccount;

            bankBGZBNPParibas.createBankAccount(client2);
            string client2BankNumber = client2.getLastCreatedProductNumber();
            Console.WriteLine(client2BankNumber);
            BankAccount account2 = client2.getBankProduct(client2BankNumber) as BankAccount;




            bankMillenium.paymentOnAccount(account1, 10000);
            bankMillenium.paymentOnAccount(account3, 10000);
            bankBGZBNPParibas.paymentOnAccount(account2, 10000);
            System.Console.WriteLine("BankAccount1: " + account1.balance);
            System.Console.WriteLine("BankAccount2: " + account2.balance);
            System.Console.WriteLine("BankAccount3: " + account3.balance);

            bankMillenium.crossbankMoneyTransfer(account1, bankBGZBNPParibas.id, account2.getAccountNumber(), 3000);
            KIR.Instance.performElixirSession();
            System.Console.WriteLine("BankAccount1: " + account1.balance);
            System.Console.WriteLine("BankAccount2: " + account2.balance);
            System.Console.WriteLine("BankAccount3: " + account3.balance);


            var accountDecoratorDebet = new BankAccountDecorator(account3);
            bankMillenium.transferMoney(account3, account1, 13000);

            System.Console.WriteLine("BankAccount1: " + account1.balance);
            System.Console.WriteLine("BankAccount2: " + account2.balance);
            System.Console.WriteLine("BankAccount3: " + account3.balance);
            System.Console.WriteLine("BankAccount3Debet: " + account3.debet.balance);
            System.Console.ReadKey();
        }
    }
}
