using System;
using System.Timers;

public class UnderseaRestaurant : Restaurant, IExtraDetails, IDeepFryer
{
    private int milesUndersea;
    private int maxTemp = 200;
    private int currentTemp;
    private bool isHeating = false;
    private Timer newTimer;
    public UnderseaRestaurant(string name, float income, float loss, int milesUndersea) : base(name, income, loss)
    {
        this.milesUndersea = milesUndersea;
    }

    public int MilesUndersea { get => milesUndersea; set => milesUndersea = value; }

       public string SoundMaxAlarm()
    {
        Console.WriteLine("The deep fryer is at it's maximum");
        return "Beep beep beep beep!";
    }

    public bool StartHeating()
    {
        this.isHeating = !isHeating;
        newTimer = new Timer() ;
        newTimer.Elapsed += new ElapsedEventHandler(fryerHeatingUp);
        newTimer.Interval = 2000 ;
        newTimer.Start();
        return this.isHeating;
    }

    private void fryerHeatingUp(object sender, ElapsedEventArgs e)
    {
        if (currentTemp <= maxTemp) {
            currentTemp = currentTemp + 5;
        }
        else {
            SoundMaxAlarm();
        }
        Console.WriteLine("\rIt is {0} and the temperature is now {1}", DateTime.Now.ToString(), currentTemp.ToString());
    }

    public bool StopHeating()
    {
        newTimer.Stop();
        this.currentTemp = 0;
        this.isHeating = !this.isHeating;
        return this.isHeating;
    }
    
    string IExtraDetails.ExtraDetails()
    {
        return "This restaurant pretends it is " + this.milesUndersea + " miles under the sea.\n";
    }
}