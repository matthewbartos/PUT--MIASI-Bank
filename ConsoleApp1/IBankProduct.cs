using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface IBankProduct
    {
        void calculatePercentage();
        void setPercentageMechanism(Percentage mechanism);
        void addOperation(IBankOperation bankOperation);
    }
}
