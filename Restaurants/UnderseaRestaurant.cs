public class UnderseaRestaurant : Restaurant
{
    private int milesUndersea;
    public UnderseaRestaurant(string name, float income, float loss, int milesUndersea) : base(name, income, loss)
    {
        this.milesUndersea = milesUndersea;
    }

    public override string ExtraDetails()
    {
        return "This restaurant pretends it is " + this.milesUndersea + " miles under the sea.\n";
    }
}