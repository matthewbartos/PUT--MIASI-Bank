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

        public void subtractMoney(float value) {
            if(debet != null) {
                if(balance - value < 0) {
                    var rest = value - balance;
                    if (debet.balance + rest <= debet.maxDebet)
                    {
                        debet.balance += rest;
                        balance = 0;
                    }
                } else {
                    balance -= value;
                }
            } else {
                if (balance - value > 0)
                {
                    balance -= value;
                }
            }
        }

        public void addMoney(float value)
        {
            if (debet != null)
            {
                if (debet.balance > 0)
                {
                    var rest = debet.balance - value;
                    if(rest >= 0) {
                        debet.balance -= value;
                    } else {
                        balance += rest;
                        debet.balance = 0;
                    }
                }
                else
                {
                    balance += value;
                }
            }
            else
            {
                balance += value;
            }
        }
    }
}
