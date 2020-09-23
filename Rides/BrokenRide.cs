public class BrokenRide : ThemeParkRide, IExtraDetails
{
    public BrokenRide(string name) : base(name, 0)
    {
    }

    string IExtraDetails.ExtraDetails()
    {
        return "This is an example of a broken ride and should not be counted in the total right now";
    }
}