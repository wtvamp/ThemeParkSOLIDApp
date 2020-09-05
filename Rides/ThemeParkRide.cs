public abstract class ThemeParkRide : IThemeParkRide
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

    public virtual string RideDetails()
    {
        return this.Name + " which goes " + this.Speed + "\n";
    }

    public virtual string ExtraDetails()
    {
        throw new System.NotImplementedException();
    }
}