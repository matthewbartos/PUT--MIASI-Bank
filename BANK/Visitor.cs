using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Visitor
    {
        public virtual void visit(BankAccount ba)
        {}

        public virtual void visit(Credit credit)
        {}

        public virtual void visit(Deposit deposit)
        {}
    }
}
