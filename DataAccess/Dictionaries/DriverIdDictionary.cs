namespace DataAccess.Dictionaries;

public static class DriverIdDictionary
{        
    private static readonly Dictionary<string, string> DriverIDs = new()
    {
        {"Alexander Albon", "albon"},
        {"Fernando Alonso", "alonso" },
        {"Valtteri Bottas", "bottas"},
        {"Pierre Gasly", "gasly"},
        {"Lewis Hamilton", "hamilton"},
        {"Nico Hulkenebrg", "hulkenberg"},
        {"Charles Leclerc", "leclerc"},
        {"Kevin Magnussen", "kevin_magnussen"},
        {"Lando Norris", "norris"},
        {"Esteban Ocon", "ocon"},
        {"Sergio Perez", "perez"},
        {"Carlos Sainz", "sainz"},
        {"Logan Sargent", "sargent"},
        {"Lance Stroll", "stroll"},
        {"Yuki Tsunoda", "tsunoda"},
        {"Max Verstappen", "max_verstappen"},
        {"Nyck de Vries", "de_vries"},
        {"Guanyu Zhou", "zhou"}
    };

    public static string GetDriverId (string driverName)
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

