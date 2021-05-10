public class CoasterRide : ThemeParkRide
{
    private int numberOfLoops;
    public CoasterRide(string name, float speed, int numberOfLoops): base(name, speed)
    {
        this.numberOfLoops = numberOfLoops;
    }
    public override string ExtraDetails() {
        return this.Name + " is a coaster ride which has " + this.numberOfLoops.ToString() + " loops.\n";
    }
} 