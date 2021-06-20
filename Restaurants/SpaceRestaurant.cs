public class SpaceRestaurant : Restaurant, IExtraDetails
{
    private int milesFromEarth;
    public SpaceRestaurant(string name, float income, float loss, int milesFromEarth) : base(name, income, loss)
    {
        this.milesFromEarth = milesFromEarth;
    }

    public int MilesFromEarth { get => milesFromEarth; set => milesFromEarth = value; }

    string IExtraDetails.ExtraDetails()
    {
        return this.Name + " pretends it is " + this.milesFromEarth + " miles from Earth.\n";
    }
}