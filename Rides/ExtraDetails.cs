public class ExtraDetails : IExtraDetails
{
    public string extraDetails;

    public ExtraDetails(string extraDetails)
    {
        this.extraDetails = extraDetails;
    }
    string IExtraDetails.ExtraDetails()
    {
        return "This ride has extra details: \n" + extraDetails;
    }
}