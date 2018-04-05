using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        private List<Client> clients;
        private List<BankProduct> bankProducts;

        public void makeDeposit(BankProduct destination, float value) {
            BankOperation bankOperation = new BankOperation();
            bankOperation.value = value;
           // bankOperation.desitnation = destination;

           // bankOperation.commit();
        }

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

        public void createBankAccount(Client client)
        {
            String number = generateUniqueAccountNumber();
            BankAccount bankAccount = new BankAccount(number, "", client);
            bankProducts.Add(bankAccount);
        }

        public void createBankCredit(BankAccount account)
        {
            String number = generateUniqueAccountNumber();
            Credit bankCredit = new Credit(number, account);
            bankProducts.Add(bankCredit);
        }

    }
}
