using System;

public class SpinningRide : ThemeParkRide, IExtraDetails, ISpinningEngine
{
    private float spinningDegree;
    private float spinningSpeed;
    private bool isRideStarted;
        
    public SpinningRide(string name, float speed, float spinningDegree, float spinningSpeed): base(name, speed)
    {
        this.spinningSpeed = spinningSpeed;
        this.spinningDegree = spinningDegree;
    }

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

    string IExtraDetails.ExtraDetails()
    {
        return this.Name + " is a spinning ride that spins " + this.spinningDegree.ToString() +
        " degrees at " + this.spinningSpeed.ToString() + "mph.\n";
    }
}