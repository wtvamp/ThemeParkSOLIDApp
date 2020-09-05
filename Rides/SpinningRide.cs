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
        return base.ExtraDetails();
    }
}