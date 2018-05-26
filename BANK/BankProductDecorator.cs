using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccountDecorator : IBankProduct
    {
        public BankAccount bankAccount;
        public BankAccountDecorator(BankAccount ba)
        {
            bankAccount = ba;
            bankAccount.debet = new Debet(0, 10000);
        }

        public void addOperation(IBankOperation bankOperation)
        {
            bankAccount.addOperation(bankOperation);
        }

        public float calculatePercentage()
        {
            return bankAccount.calculatePercentage();
        }

        public void setPercentageMechanism(Percentage mechanism)
        {
            bankAccount.setPercentageMechanism(mechanism);
        }
    }
}
