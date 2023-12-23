using System;

public class Lasagna
{
    // 1. Define the expected oven time in minutes
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // 2. Calculate the remaining oven time in minutes
    public int RemainingMinutesInOven(int actualTime)
    {
        return ExpectedMinutesInOven() - actualTime;
    }
    // 3. Calculate the preparation time in minutes
    public int PreparationTimeInMinutes(int numberLayers)
    {
        return 2 * numberLayers;
    }
    // 4. Calculate the elapsed time in minutes
    public int ElapsedTimeInMinutes(int numberLayers, int actualTime)
    {
        return 2 * numberLayers + actualTime;
    }
}