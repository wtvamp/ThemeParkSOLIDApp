// These however, are open for modification
public class SpinningRide : ThemeParkRide
{
    private float spinningDegree;
    private float spinningSpeed;

    public SpinningRide(string name, int speed, float spinningDegree, float spinningSpeed): base(name, speed)
    {
        this.spinningDegree = spinningDegree;
        this.spinningSpeed = spinningSpeed;
    }

    public override string ExtraDetails()
    {
        return this.Name + " is a spinning ride that spins " + this.spinningDegree.ToString() +
        " degrees at " + this.spinningSpeed.ToString() + "mph.\n";
    }
}