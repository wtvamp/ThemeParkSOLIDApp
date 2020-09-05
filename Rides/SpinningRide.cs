public class SpinningRide : ThemeParkRide
{
    private float spinningDegree;
    private float spinnigSpeed;
    public SpinningRide(string name, float speed, float spinningDegree, float spinningSpeed): base(name, speed)
    {
        this.spinnigSpeed = spinnigSpeed;
        this.spinningDegree = spinningDegree;
    }
    public override string ExtraDetails()
    {
        return this.Name + " is a spinning ride that spins " + this.spinningDegree.ToString() +
        " degrees at " + this.spinnigSpeed.ToString() + "mph.\n";
    }
}