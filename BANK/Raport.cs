using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Raport
    {
        private List<BankProduct> products;
        private Filter filter;

        public Raport(List<BankProduct> products)
        {
            this.products = products;
        }

        public void filterUsingParameters(float valueFrom, float valueTo, BankProduct product)
        {
            this.filter = new Filter(valueFrom, valueTo, null, null, product);
        }
    }
}
