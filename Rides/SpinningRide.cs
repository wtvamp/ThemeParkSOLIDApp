public class SpinningRide : ThemeParkRide
{
    private float spinningDegree;
    private float spinningSpeed;
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
}