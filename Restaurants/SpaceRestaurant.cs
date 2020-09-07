public class SpaceRestaurant : Restaurant
{
    private int milesFromEarth;
    public SpaceRestaurant(string name, float income, float loss, int milesFromEarth) : base(name, income, loss)
    {
        this.milesFromEarth = milesFromEarth;
    }

    public override string ExtraDetails()
    {
        return "This restaurant pretends it is " + this.milesFromEarth + " miles from Earth.\n";
    }
}