public class Restaurant {
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
    public string RestaurantDetails() {
        return this.Name + " which generates " + this.Income + " in income and costs " + this.Loss + "\n";
    }
}