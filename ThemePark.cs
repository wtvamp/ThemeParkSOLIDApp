using System;
using System.Collections.Generic;

public class ThemePark {

    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;
    public string ThemeParkRideAName { get; set; }  
    public string ThemeParkRideBName { get; set; }  
    public string ThemeParkRideCName { get; set; }  
    public float ThemeParkRideASpeed { get; set; }  
    public float ThemeParkRideBSpeed { get; set; }  
    public float ThemeParkRideCSpeed { get; set; }  
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
    private List<(string, float)> ThemeParkRides;
    private List<(string, float, float)> ThemeParkFood; 

    public ThemePark()
    {
        ThemeParkRides = new List<(string, float)>();
        ThemeParkFood = new List<(string, float, float)>();
    }
    
    private List<(string, float)> ConvertRidesNameToList() {
        ThemeParkRides.Add((ThemeParkRideAName, ThemeParkRideASpeed));
        ThemeParkRides.Add((ThemeParkRideBName, ThemeParkRideBSpeed));
        ThemeParkRides.Add((ThemeParkRideCName, ThemeParkRideCSpeed));
        return ThemeParkRides;
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
        TotalCost += (float)((ThemeParkRideASpeed + ThemeParkRideBSpeed + ThemeParkRideCSpeed) * .50 * 12);
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
        foreach ((string, float) ride in ConvertRidesNameToList()) {
            Console.WriteLine(ride.Item1 + " which goes " + ride.Item2 + "\n");
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