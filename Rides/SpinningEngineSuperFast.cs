using System;

public class SpinningEngineSuperFast : ISpinningEngine
{
    bool isRideStarted;
    public bool Start(string rideName)
    {
        if (!isRideStarted) {
            Console.WriteLine("The " + rideName + " ride is going super fast.");
            isRideStarted = true;
        }
        return isRideStarted;
    }

    public bool Stop(string rideName)
    {
        if (isRideStarted) {
            Console.WriteLine("The " + rideName + " ride came to a complete halt!");
            isRideStarted = false;
        }
        return isRideStarted;    
    }
}