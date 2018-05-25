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
            bankMillenium.createBankAccount(client3);
            bankBGZBNPParibas.createBankAccount(client2);


            bankMillenium.paymentOnAccount(client1.bankAccount, 10000);
            bankMillenium.paymentOnAccount(client3.bankAccount, 10000);
            bankBGZBNPParibas.paymentOnAccount(client2.bankAccount, 10000);
            System.Console.WriteLine("BankAccount1: " + client1.bankAccount.balance);
            System.Console.WriteLine("BankAccount2: " + client2.bankAccount.balance);
            System.Console.WriteLine("BankAccount3: " + client3.bankAccount.balance);

            bankMillenium.crossbankMoneyTransfer(client1.bankAccount, bankBGZBNPParibas.id, client2.bankAccount.getAccountNumber(), 3000);
            KIR.Instance.performElixirSession();
            System.Console.WriteLine("BankAccount1: " + client1.bankAccount.balance);
            System.Console.WriteLine("BankAccount2: " + client2.bankAccount.balance);
            System.Console.WriteLine("BankAccount3: " + client3.bankAccount.balance);


            var accountDecoratorDebet = new BankAccountDecorator(client3.bankAccount);
            bankMillenium.transferMoney(client3.bankAccount, client1.bankAccount, 13000);

            System.Console.WriteLine("BankAccount1: " + client1.bankAccount.balance);
            System.Console.WriteLine("BankAccount2: " + client2.bankAccount.balance);
            System.Console.WriteLine("BankAccount3: " + client3.bankAccount.balance);
            System.Console.WriteLine("BankAccount3Debet: " + client3.bankAccount.debet.balance);
            System.Console.ReadKey();
        }
    }
}
