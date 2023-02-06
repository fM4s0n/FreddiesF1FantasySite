namespace DataAccess.Dictionaries.Fantasy;

public  class ConstructorValueDictionary
{
    private static readonly Dictionary<string, double> ConstructorValues = new()
    {
        {"alfa", 8.0},
        {"alphatauri", 6.5},
        {"alpine", 18.0},
        {"aston_martin", 7.0},
        {"ferrari", 23.0},
        {"haas", 7.0},
        {"mclaren", 15.0},
        {"mercedes", 25.0},
        {"red_bull", 24.0},
        {"williams", 5.0}
    };

    public static double GetCurrentValue(string constructorId)
    {
        try
        {
            return ConstructorValues[constructorId];
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
