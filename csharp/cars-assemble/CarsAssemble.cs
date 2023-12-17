using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double ratio = 0;

        if (speed == 0)
        {
            ratio = 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            ratio = 1;
        }
        else if (speed >= 5 && speed <= 8)
        {
            ratio = 0.9;
        }
        else if (speed == 9)
        {
            ratio = 0.8;
        }
        else if (speed == 10)
        {
            ratio = 0.77;
        }
        return ratio;
    }

    public static double ProductionRatePerHour(int speed)
    {
        if (speed == 0)
        {
            return 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return speed * 221 * 1;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return speed * 221 * 0.9;
        }
        else if (speed == 9)
        {
            return speed * 221 * 0.8;
        }
        else if (speed == 10)
        {
            return speed * 221 * 0.77;
        }
        return 0;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double carsProducedPerMin = ProductionRatePerHour(speed) / 60;
        int resultInInt = (int)Math.Floor(carsProducedPerMin);
        return resultInInt;
    }
}
