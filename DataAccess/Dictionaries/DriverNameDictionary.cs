namespace DataAccess.Dictionaries;

public class DriverNameDictionary
{
    private static readonly Dictionary<string, string> DriverIDs = new()
    {
        {"albon", "Alexander Albon"},
        {"alonso", "Fernando Alonso"},
        {"bottas" , "Valtteri Bottas"},
        {"gasly" , "Pierre Gasly"},
        {"hamilton" , "Lewis Hamilton"},
        {"hulkenberg" , "Nico Hulkenebrg"},
        {"leclerc" , "Charles Leclerc"},
        {"kevin_magnussen" , "Kevin Magnussen"},
        {"norris" , "Lando Norris"},
        {"ocon" , "Esteban Ocon"},
        {"perez" , "Sergio Perez"},
        {"sainz" , "Carlos Sainz"},
        {"sargent", "Logan Sargent"},
        {"stroll" , "Lance Stroll"},
        {"tsunoda" , "Yuki Tsunoda"},
        {"max_verstappen" , "Max Verstappen"},
        {"de_vries" , "Nyck de Vries"},
        {"zhou" , "Guanyu Zhou"}
    };

    public static string GetDriverName(string driverId)
    {
        try
        {
            return DriverIDs[driverId];
        }
        catch
        {
            return "No data";
        }
    }
}
