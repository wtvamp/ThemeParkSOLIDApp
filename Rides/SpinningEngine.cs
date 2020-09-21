using System;

public class SpinningEngine : ISpinningEngine
{
    bool isRideStarted;
    public bool Start(string rideName)
    {
        if (!isRideStarted) {
            Console.WriteLine("The " + rideName + " ride is started.");
            isRideStarted = true;
        }
        return isRideStarted;
    }

    public bool Stop(string rideName)
    {
        if (isRideStarted) {
            Console.WriteLine("The " + rideName + " ride is stopped.");
            isRideStarted = false;
        }
        return isRideStarted;    
    }
}