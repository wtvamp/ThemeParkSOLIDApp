public class ThemeParkRide : IThemeParkRide
{
    public string Name;
    public float Speed;
    public static float TotalSpeed;

    public ThemeParkRide(string name, float speed)
    {
        this.Name = name;
        this.Speed = speed;
        TotalSpeed += speed;
    }

    public string RideDetails()
    {
        return this.Name + " which goes " + this.Speed + "\n";
    }
}