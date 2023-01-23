namespace FreddiesF1FantasySite.Dictionaries;

internal class DriverIdDictionary
{
        
    private static readonly Dictionary<string, string> DriverIDs = new()
    {
        {"Alex Albon", "albon"},
        {"Lewis Hamilton", "hamilton"}
    };

    public string GetDriverId (string driverName)
    {
        try
        {
            return DriverIDs[driverName];
        }
        catch
        {
            return "No data";
        }
    }
}

