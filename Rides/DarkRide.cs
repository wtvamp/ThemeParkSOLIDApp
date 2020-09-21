public class DarkRide : ThemeParkRide
{
    // Rated from 0-10
    private int scariness;
    private IExtraDetails extraDetails;
    public DarkRide(string name, float speed, int scariness): base(name, speed)
    {
        this.scariness = scariness;
        this.extraDetails = new ExtraDetails(this.ExtraDetails());
    }

    public string ExtraDetails() {
        return this.Name + " is a dark ride which is rated " + this.scariness.ToString() + " on a scale of 1-10.\n";
    }
}