using System.Text.Json.Serialization;

public abstract class ThemeParkRide : IThemeParkRide
{
    private long id;
    private string name;
    private float speed;
    private static float? totalSpeed = 0;

    public string Name { get => name; set => name = value; }
    public float Speed { get => speed; set => speed = value; }
    public static float? TotalSpeed { get => totalSpeed; set => totalSpeed = value; }
    public long Id { get => id; set => id = value; }

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
}