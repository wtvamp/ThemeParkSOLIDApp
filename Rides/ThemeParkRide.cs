public class ThemeParkRide {
    public string Name;
    public float Speed;

    public ThemeParkRide(string name, float speed)
    {
        this.Name = name;
        this.Speed = speed;

    }
    public string RideDetails() {
        return this.Name + " which goes " + this.Speed + "\n";
    }
}