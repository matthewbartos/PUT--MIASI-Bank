﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Credit: BankProduct
    {
        private Interest interes;
        public Credit(string number) : base(number)
        {

        }
    }
}
