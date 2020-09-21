public class BrokenRide : ThemeParkRide, IExtraDetailsRide
{
    public BrokenRide(string name) : base(name, 0)
    {
    }

    public string ExtraDetails()
    {
        //TotalSpeed = null;
        return "This is an example of a broken ride and should not be counted in the total right now";
    }
}