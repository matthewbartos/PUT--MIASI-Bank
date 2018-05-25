using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Client
    {
        private string name;
        private string surname;
        private Dictionary<String, BankProduct> products;
        private BankProduct lastCreatedBankProduct;

        public Client(string name, string surname)
        {
            this.products = new Dictionary<string, BankProduct>();
            this.name = name;
            this.surname = surname;
        }

        public void addBankProduct(BankProduct account) {
            this.products.Add(account.getAccountNumber(), account);
            this.lastCreatedBankProduct = account;
        }

        public BankProduct getBankProduct(string number) {
            return this.products[number];
        }

        public string getLastCreatedProductNumber() {
            return lastCreatedBankProduct.getAccountNumber();
        }

    }
}
