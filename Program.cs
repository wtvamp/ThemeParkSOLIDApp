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
            warwarLand.ThemeParkRides.Add(new DarkRide("Pirates of the Caribean", 5, 4));
            warwarLand.ThemeParkRides.Add(new SpinningRide("Teacups", 7, 360, 9));
            warwarLand.ThemeParkRides.Add(new CoasterRide("Space Mountain", 12, 0));
            warwarLand.ThemeParkRides.Add(new SpinningRide("Dumbo", -100, 360, 5));
            warwarLand.PrintRides();

            warwarLand.RestaurantAName = "Pizzasaurus Rex";
            warwarLand.RestaurantAIncome = 5;
            warwarLand.RestaurantALoss = 3;
            warwarLand.RestaurantBName = "Planet Mars Burgers";
            warwarLand.RestaurantBIncome = 8;
            warwarLand.RestaurantBLoss = 7.5F;
            warwarLand.RestaurantCName = "Salads Undersea";
            warwarLand.RestaurantCIncome = 3;
            warwarLand.RestaurantCLoss = 6;
            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
