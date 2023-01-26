namespace DataAccess.Dictionaries.Fantasy;

public class DriverValueDictionary
{
    private static readonly Dictionary<string, double> DriverValues = new()
    {
        {"albon", 6.0},
        {"alonso", 12.0},
        {"bottas", 10},
        {"gasly", 15.0},
        {"hamilton", 25.0},
        {"hulkenberg", 5.5},
        {"leclerc", 27.5},
        {"kevin_magnussen", 7.5},
        {"norris", 16.0},
        {"ocon", 15.0 },
        {"perez", 20.5},
        {"piastri", 12.5},
        {"russell", 21.0},
        {"sainz", 20.0},
        {"sargeant", 5.0},
        {"stroll", 9.0},
        {"tsunoda", 6.5},
        {"max_verstappen", 30.0},
        {"de_vries", 7.0},
        {"zhou", 6.0}
    };

    public static double GetDriverValue(string driverId)
    {
        try
        {
            return DriverValues[driverId];
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
