public class DarkRide : ThemeParkRide, IExtraDetails
{
    // Rated from 0-10
    private int scariness;
    public DarkRide(string name, float speed, int scariness): base(name, speed)
    {
        this.scariness = scariness;
    }

    public int Scariness { get => scariness; set => scariness = value; }

    string IExtraDetails.ExtraDetails()
    {
        return this.Name + " is a dark ride which is rated " + this.scariness.ToString() + " on a scale of 1-10.\n";
    }
}