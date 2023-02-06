
namespace DataAccess.Dictionaries;

public class DriverConstructorIdDisctionary
{
    private static readonly Dictionary<string, string> DriverConstructorIds = new()
    {
        {"albon", "williams"},
        {"alonso", "aston_martin"},
        {"bottas" , "alfa"},
        {"gasly" , "alpine"},
        {"hamilton" , "mercedes"},
        {"hulkenberg" , "haas"},
        {"leclerc" , "ferrari"},
        {"kevin_magnussen" , "haas"},
        {"norris" , "mclaren"},
        {"ocon" , "alpine"},
        {"perez" , "red_bull"},
        {"piastri", "mclaren"},
        {"russell", "mercedes"},
        {"sainz" , "ferrari"},
        {"sargeant", "williams"},
        {"stroll" , "aston_martin"},
        {"tsunoda" , "alphatauri"},
        {"max_verstappen" , "red_bull"},
        {"de_vries" , "alphatauri"},
        {"zhou" , "alfa"}
    };

    public static string GetDriversConstructorId(string driverId)
    {
        try
        {
            return DriverConstructorIds[driverId];
        }
        catch
        {
            return "No data";
        }
    }
}
