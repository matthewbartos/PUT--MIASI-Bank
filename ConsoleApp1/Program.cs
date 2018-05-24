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
            Client client2 = new Client("Mateusz", "Bartos");
            bankMillenium.createBankAccount(client1);
            bankBGZBNPParibas.createBankAccount(client2);


            bankMillenium.paymentOnAccount(client1.bankAccount, 10000);
            bankBGZBNPParibas.paymentOnAccount(client2.bankAccount, 10000);

            System.Console.WriteLine("BankAccount1: " + client1.bankAccount.balance);
            System.Console.WriteLine("BankAccount2: " + client2.bankAccount.balance);

            bankMillenium.crossbankMoneyTransfer(client1.bankAccount, bankBGZBNPParibas.id, client2.bankAccount.getAccountNumber(), 3000);
            KIR.Instance.performElixirSession();

            System.Console.WriteLine("BankAccount1: " + client1.bankAccount.balance);
            System.Console.WriteLine("BankAccount2: " + client2.bankAccount.balance);

        }
    }
}
