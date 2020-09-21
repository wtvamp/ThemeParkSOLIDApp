public class SpinningRide : ThemeParkRide, IExtraDetailsRide, ISpinningEngine
{
    private float spinningDegree;
    private float spinningSpeed;
    private bool isRideSpinning;
    public SpinningRide(string name, float speed, float spinningDegree, float spinningSpeed): base(name, speed)
    {
        this.spinningSpeed = spinningSpeed;
        this.spinningDegree = spinningDegree;
    }
    public string ExtraDetails()
    {
        return this.Name + " is a spinning ride that spins " + this.spinningDegree.ToString() +
        " degrees at " + this.spinningSpeed.ToString() + "mph.\n";
    }

    public bool Start()
    {
        if (!isRideSpinning) {
            isRideSpinning = true;
        }
        return isRideSpinning;
    }

    public bool Stop()
    {
        if (!isRideSpinning) {
            isRideSpinning = false;
        }
        return isRideSpinning;   
    }
}