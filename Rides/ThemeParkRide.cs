public abstract class ThemeParkRide : IThemeParkRide
{
    public string Name;
    public float Speed;
    public static float? TotalSpeed = 0;

    public ThemeParkRide(string name, float speed)
    {
        this.Name = name;
        this.Speed = speed;
        TotalSpeed += speed;
    }

    public virtual string RideDetails()
    {
        return this.Name + " goes " + this.Speed + "mph.\n";
    }

    public virtual string ExtraDetails()
    {
        // Notice how this method exists on the base class only to throw an exception?
        // This is an example of violating the interface segregation principle
        throw new System.NotImplementedException();
    }
}