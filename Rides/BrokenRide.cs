public class BrokenRide : ThemeParkRide
{
    public BrokenRide(string name) : base(name, 0)
    {
    }

    public override string ExtraDetails()
    {
        TotalSpeed = null;
        return "This is an example of a broken ride and should not be counted in the total right now";
    }
}