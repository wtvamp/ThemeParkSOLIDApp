using System;
using System.Collections.Generic;

namespace SOLIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IThemeParkRide> themeParkRides = new List<IThemeParkRide>();
            themeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            themeParkRides.Add(new BrokenRide("Pirates of the Carribean"));
            themeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));

            ThemePark warwarLand = new ThemePark(themeParkRides);
            warwarLand.TicketCost = 90;
            warwarLand.AverageDailyAttendance = 50000;            
            warwarLand.ThemeParkName = "War War Land";

            themeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            themeParkRides.Add(new BrokenRide("Pirates of the Carribean"));
            //warwarLand.ThemeParkRides.Add(new DarkRide("Pirates of the Carribean", 5, 4));
            warwarLand.PrintRides();

            warwarLand.Restaurants.Add(new SpaceRestaurant("Pizzasaurus Rex", 5, 3, 1000));
            warwarLand.Restaurants.Add(new SpaceRestaurant("Planet Mars Burgers", 8, 7.5F, 1000));
            warwarLand.Restaurants.Add(new UnderseaRestaurant("Salads Undersea", 3, 6, 1000));
            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
