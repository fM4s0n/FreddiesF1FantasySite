namespace DataAccess.Dictionaries;

public class DriverIdDictionary
{
        
    private static readonly Dictionary<string, string> DriverIDs = new()
    {
        {"Alexander Albon", "albon"},
        {"Fernando Alonso", "alonso" },
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

