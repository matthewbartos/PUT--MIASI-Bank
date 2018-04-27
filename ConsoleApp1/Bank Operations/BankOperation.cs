using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankOperation : IBankOperation
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

        public void SetOperationData(BankProduct bankProductSource = null, BankProduct bankProductDestination = null, DateTime? date = null, float value = 0)
        {
            
        }
    }
}
