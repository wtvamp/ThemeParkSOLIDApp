using System;

namespace SOLIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemePark warwarLand = new ThemePark();
            warwarLand.TicketCost = 90;
            warwarLand.AverageDailyAttendance = 50000;            
            warwarLand.ThemeParkName = "War War Land";

            warwarLand.ThemeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));
            warwarLand.ThemeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            warwarLand.ThemeParkRides.Add(new DarkRide("Pirates of the Carribean", 5, 4));
            warwarLand.PrintRides();

            warwarLand.Restaurants.Add(new Restaurant("Pizzasaurus Rex", 5, 3));
            warwarLand.Restaurants.Add(new Restaurant("Planet Mars Burgers", 8, 7.5F));
            warwarLand.Restaurants.Add(new Restaurant("Salads Undersea", 3, 6));
            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
