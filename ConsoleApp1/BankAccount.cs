using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount: BankProduct
    {
        private string name;
        private Client client;
        private Debet _debet = null; // may be sth or not

        public Debet debet
        {
            get
            {
                return _debet;
            }
            set
            {
                this._debet = value;
            }
        }

        public BankAccount(string number, string name, Client client): base(number) {
            this.name = name;
            this.debet = null;
            this.client = client;
        }

        public override void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
