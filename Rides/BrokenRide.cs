using Microsoft.Extensions.Logging;

public class BrokenRide : ThemeParkRide, IExtraDetails
{
    ILogger _logger;
    public BrokenRide(string name, ILogger logger) : base(name, 0)
    {
        _logger = logger;
    }

    string IExtraDetails.ExtraDetails()
    {
        _logger.LogError("This is an example of a broken ride and should not be counted in the total right now");
        return "This is an example of a broken ride and should not be counted in the total right now";
    }
}