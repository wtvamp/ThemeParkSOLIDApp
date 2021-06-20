public abstract class Restaurant : IRestaurant
{
    private string name;
    private float income;
    private float loss;
    private static float totalIncome;
    private static float totalLoss;

    public string Name { get => name; set => name = value; }
    public float Income { get => income; set => income = value; }
    public float Loss { get => loss; set => loss = value; }
    public static float TotalIncome { get => totalIncome; set => totalIncome = value; }
    public static float TotalLoss { get => totalLoss; set => totalLoss = value; }

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
}