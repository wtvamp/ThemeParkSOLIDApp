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
            warwarLand.ThemeParkRideAName = "Haunted Mansion";
            warwarLand.ThemeParkRideASpeed = 5;
            warwarLand.ThemeParkRideBName = "Teacups";
            warwarLand.ThemeParkRideBSpeed = 7;
            warwarLand.ThemeParkRideCName = "Pirates of the Caribean";
            warwarLand.ThemeParkRideCSpeed = 5;
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
