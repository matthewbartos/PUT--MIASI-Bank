using System;
namespace Bank
{
    public class LinearPercentage: Percentage
    {
        public LinearPercentage(float percent) : base()
        {
            this.currentPercent = percent;
        }

        public override float calculate(float balance)
        {
            return (this.currentPercent / 100) * balance;
        }
    }
}
