using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Deposit: BankProduct
    {
        private Interest interest;
        public Deposit(string number) : base(number) {

        }
    }
}
