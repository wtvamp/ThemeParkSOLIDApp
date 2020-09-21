public class SpinningRide : ThemeParkRide
{
    private float spinningDegree;
    private float spinningSpeed;
    
    private ISpinningEngine spinningEngine;
    private IExtraDetails extraDetails;
    public SpinningRide(string name, float speed, float spinningDegree, float spinningSpeed): base(name, speed)
    {
        this.spinningSpeed = spinningSpeed;
        this.spinningDegree = spinningDegree;
        this.extraDetails = new ExtraDetails(this.ExtraDetails());
        this.spinningEngine = new SpinningEngine();
    }
    private string ExtraDetails()
    {
        return this.Name + " is a spinning ride that spins " + this.spinningDegree.ToString() +
        " degrees at " + this.spinningSpeed.ToString() + "mph.\n";
    }
}