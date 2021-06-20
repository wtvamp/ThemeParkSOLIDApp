using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;

namespace SOLIDApp
{
    class ThemeParkApp
    {
        private readonly ILogger _logger;
        public ThemeParkApp(ILogger<ThemeParkApp> logger)
        {
            _logger = logger;
        }
        public void Start()
        {
            _logger.LogInformation($"ThemeParkApp Started at {DateTime.Now}");
            
            List<IThemeParkRide> themeParkRides = new List<IThemeParkRide>();
            themeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            themeParkRides.Add(new BrokenRide("Pirates of the Carribean", _logger));
            themeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "ride_events",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                foreach (var rideToCreate in themeParkRides) {
                    var body = Encoding.UTF8.GetBytes(
                        JsonSerializer.Serialize<object>((object)rideToCreate, 
                        new JsonSerializerOptions
                        {
                            IncludeFields = true, MaxDepth = 5
                        })
                    );

                    channel.BasicPublish(exchange: "rides",
                                        routingKey: "ride.create",
                                        basicProperties: null,
                                        body: body);
                }
            }

            ThemePark warwarLand = new ThemePark(themeParkRides);
            warwarLand.TicketCost = 90;
            warwarLand.AverageDailyAttendance = 50000;            
            warwarLand.ThemeParkName = "War War Land";

            warwarLand.PrintRides();

            warwarLand.Restaurants.Add(new SpaceRestaurant("Pizzasaurus Rex", 5, 3, 1000));
            warwarLand.Restaurants.Add(new SpaceRestaurant("Planet Mars Burgers", 8, 7.5F, 1000));
            warwarLand.Restaurants.Add(new UnderseaRestaurant("Salads Undersea", 3, 6, 1000));
            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
            //LoadDashboard();
        }

        public void Stop()
        {
            _logger.LogInformation($"ThemeParkApp Stopped at {DateTime.Now}");
        }

        public void HandleError(Exception ex)
        {
            _logger.LogError($"ThemeParkApp Error Encountered at {DateTime.Now} & Error is: {ex.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            ThemeParkApp app = serviceProvider.GetService<ThemeParkApp>();
            try
            {
                app.Start();
            }
            catch (Exception ex)
            {
                app.HandleError(ex);
            }
            finally
            {
                app.Stop();
            }
            Console.ReadLine();
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
            .AddTransient<ThemeParkApp>();
        }
    }
}
