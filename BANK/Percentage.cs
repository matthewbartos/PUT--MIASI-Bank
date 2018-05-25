using System;

public abstract class Percentage
{
    public float currentPercent;

    public Percentage() {
	}

    public abstract float calculate(float balance);
}
