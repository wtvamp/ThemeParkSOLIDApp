public abstract class Restaurant : IRestaurant
{
    public string Name;
    public float Income;
    public float Loss;
    public static float TotalIncome;
    public static float TotalLoss;

    public Restaurant(string name, float income, float loss)
    {
        this.Name = name;
        this.Income = income;
        this.Loss = loss;
        TotalIncome += income;
        TotalLoss += loss;
    }

    public virtual string RestaurantDetails()
    {
        return this.Name + " which generates " + this.Income + " in income and costs " + this.Loss + "\n";
    }

    public virtual string ExtraDetails()
    {
        throw new System.NotImplementedException();
    }
}