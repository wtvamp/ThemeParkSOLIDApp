// This is now closed for modification
public abstract class ThemeParkRide {
    public string Name;
    public float Speed;
    public static float? TotalSpeed = 0;

    public ThemeParkRide(string name, float speed)
    {
        this.Name = name;
        this.Speed = speed;
        TotalSpeed += speed;
    }

    public virtual string RideDetails() {
        return this.Name + " which goes " + this.Speed + "\n";
    }

    public virtual string ExtraDetails()
    {
        throw new System.NotImplementedException();
    }
}