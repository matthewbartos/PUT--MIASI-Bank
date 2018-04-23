using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Debet
    {
        private float _balance;
        public float maxDebet;

        public float balance {
            get {
                return _balance; 
            }

            set {
                this._balance = value;
            }
        }


        public Debet(float balance, float maxDebet) {
            this.balance = balance;
            this.maxDebet = maxDebet;
        }

    }
}
