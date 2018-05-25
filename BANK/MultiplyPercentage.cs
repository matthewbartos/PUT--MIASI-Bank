using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class MulitplyPercentage : Percentage
    {
        private float constMultiplier;
        public MulitplyPercentage(float percent) : base()
        {
            this.constMultiplier = 1.2f;
            this.currentPercent = percent;
        }

        public override float calculate(float balance)
        {
            this.currentPercent = this.currentPercent * this.constMultiplier;
            return (this.currentPercent / 100) * balance;
        }
    }
}
