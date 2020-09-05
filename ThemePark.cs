using System;
using System.Collections.Generic;
using System.Linq;

public class ThemePark {
    public List<ThemeParkRide> ThemeParkRides;
    public List<Restaurant> Restaurants;
    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;
    private float TotalIncome { get; set; }  
    private float TotalCost { get; set; }  

    public ThemePark()
    {
        Restaurants = new List<Restaurant>();
        ThemeParkRides = new List<ThemeParkRide>();
    }

    private void CalculateTotalRestaurantIncome() {
        TotalIncome += AverageDailyAttendance * (Restaurant.TotalIncome/3);
    }

    private void CalculateTotalRestaurantCost() {
        TotalCost += AverageDailyAttendance * (Restaurant.TotalLoss/3);
    }

    private void CalculateTotalRideIncome() {
        TotalIncome += TicketCost * AverageDailyAttendance;
    }

    private void CalculateTotalRideCost() {
        TotalCost += (float)(ThemeParkRide.TotalSpeed * .50 * 12);
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
        foreach (Restaurant restaurant in Restaurants) {
            Console.WriteLine(restaurant.RestaurantDetails());
        }
    }

    public void PrintProfit() {
        Console.WriteLine(ThemeParkName + " makes " + CalculateProfit() + " in income.");
    }
}