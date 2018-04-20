using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankOperation : IOperation
    {
        private BankProduct bankProductSource;
        private BankProduct bankProductDestination;
        private DateTime date;
        private float _value;

        public float value {
            get {
                return _value;
            }

            set {
                this._value = value;
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
