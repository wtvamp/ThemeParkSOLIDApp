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

            warwarLand.ThemeParkRides.Add(new ThemeParkRide("Haunted Mansion", 5));
            warwarLand.ThemeParkRides.Add(new ThemeParkRide("Teacups", 7));
            warwarLand.ThemeParkRides.Add(new ThemeParkRide("Pirates of the Caribean", 5));
            warwarLand.PrintRides();

            warwarLand.Restaurants.Add(new Restaurant("Pizzasaurus Rex", 5, 3));
            warwarLand.Restaurants.Add(new Restaurant("Planet Mars Burgers", 8, 7.5F));
            warwarLand.Restaurants.Add(new Restaurant("Salads Undersea", 3, 6));
            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
