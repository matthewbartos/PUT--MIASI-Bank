using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Bank
    {
        private List<Client> clients;
        private List<BankProduct> bankProducts;
        private History bankHistory;


        public void makeDeposit(BankProduct destination, float value) {
            BankOperation bankOperation = new BankOperation();
            bankOperation.value = value;
           // bankOperation.desitnation = destination;

           // bankOperation.commit();
        }

    }
}
