using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Filter
    {
        private float valueFrom;
        private float valueTo;

        private DateTime? dateFrom;
        private DateTime? dateTo;
 
        private BankProduct product;

        public Filter(float valueFrom, float valueTo, DateTime? dateFrom, DateTime? dateTo, BankProduct product)
        {
            this.valueFrom = valueFrom;
            this.valueTo = valueTo;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.product = product;
        }

    }
}
