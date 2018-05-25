using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class CubicPercentage : Percentage
    {
        public CubicPercentage(float percent) : base()
        {
            this.currentPercent = percent;
        }

        public override float calculate(float balance)
        {
            var income = (this.currentPercent / 100) * balance;
            this.currentPercent = this.currentPercent * this.currentPercent;
            return income;
        }
    }
}
