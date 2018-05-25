using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class BankOperation : IBankOperation
    {
        protected BankProduct bankProductSource;
        protected BankProduct bankProductDestination;
        protected DateTime date;
        protected float _value;

        public float value
        {
            get
            {
                return _value;
            }

            set
            {
                this._value = value;
            }
        }

        public abstract void Execute();
        public abstract void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0);
    }
}
