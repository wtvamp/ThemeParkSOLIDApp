public class BrokenRide : ThemeParkRide
{
    private IExtraDetails extraDetails;
    public BrokenRide(string name) : base(name, 0)
    {
        this.extraDetails = new ExtraDetails(this.ExtraDetails());
    }

    public string ExtraDetails()
    {
        //TotalSpeed = null;
        return "This is an example of a broken ride and should not be counted in the total right now";
    }
}