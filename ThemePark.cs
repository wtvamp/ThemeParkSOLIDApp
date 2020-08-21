using System;
using System.Collections.Generic;
using System.Linq;

public class ThemePark {

    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;
    public List<ThemeParkRide> ThemeParkRides;
    public string RestaurantAName { get; set; }  
    public string RestaurantBName { get; set; }  
    public string RestaurantCName { get; set; }  
    public float RestaurantAIncome { get; set; }  
    public float RestaurantBIncome { get; set; }  
    public float RestaurantCIncome { get; set; }  
    public float RestaurantALoss { get; set; }  
    public float RestaurantBLoss { get; set; }  
    public float RestaurantCLoss { get; set; }  
    private float TotalIncome { get; set; }  
    private float TotalCost { get; set; }  
    private List<(string, float, float)> ThemeParkFood; 

    public ThemePark()
    {
        ThemeParkFood = new List<(string, float, float)>();
        ThemeParkRides = new List<ThemeParkRide>();
    }

    public float CalculateRideSpeedTotal() {
        return ThemeParkRides.Sum(ride => ride.Speed);
    }

    public float CalculateRideSpeedAverage()  
    {  
        return CalculateRideSpeedTotal() / ThemeParkRides.Count;
    }

    private List<(string, float, float)> ConvertRestaurantsToList() {
        ThemeParkFood.Add((RestaurantAName, RestaurantAIncome, RestaurantALoss));
        ThemeParkFood.Add((RestaurantBName, RestaurantBIncome, RestaurantBLoss));
        ThemeParkFood.Add((RestaurantCName, RestaurantCIncome, RestaurantCLoss));
        return ThemeParkFood;
    }

    private void CalculateTotalRestaurantIncome() {
        TotalIncome += AverageDailyAttendance * ((RestaurantAIncome + RestaurantBIncome + RestaurantCIncome)/3);
    }

    private void CalculateTotalRestaurantCost() {
        TotalCost += AverageDailyAttendance * ((RestaurantALoss + RestaurantBLoss + RestaurantCLoss)/3);
    }

    private void CalculateTotalRideIncome() {
        TotalIncome += TicketCost * AverageDailyAttendance;
    }

    private void CalculateTotalRideCost() {
        TotalCost += (float)(CalculateRideSpeedTotal() * .50 * 12);
    }

    private float CalculateProfit()  
    {  
        CalculateTotalRestaurantIncome();
        CalculateTotalRestaurantCost();
        CalculateTotalRideCost();
        CalculateTotalRideIncome();
        return TotalIncome - TotalCost;  
    }

    public void PrintRides() {
        Console.WriteLine(ThemeParkName + " contains the following rides: \n");
        foreach (ThemeParkRide ride in ThemeParkRides) {
            Console.WriteLine(ride.RideDetails());
        }
    }

    public void PrintRestaurants() {
        Console.WriteLine(ThemeParkName + " contains the following restaurants: \n");
        foreach ((string, float, float) restaurant in ConvertRestaurantsToList()) {
            Console.WriteLine(restaurant.Item1 + " which generates " + restaurant.Item2 + " in income and costs " + restaurant.Item3 + "\n");
        }
    }

    public void PrintProfit() {
        Console.WriteLine(ThemeParkName + " makes " + CalculateProfit() + " in income.");
    }
}