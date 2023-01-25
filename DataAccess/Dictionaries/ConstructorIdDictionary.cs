namespace DataAccess.Dictionaries;

public class ConstructorIdDictionary
{
    private static readonly Dictionary<string, string> ConstructorIDs = new()
    {
        {"Alfa Romeo", "alfa"},
        {"AlphaTauri", "alphatauri"},
        {"Alpine F1 Team", "alpine"},
        {"Aston Martin", "aston_martin"},
        {"Ferrari", "ferrari"},
        {"Haas F1 Tea,", "haas"},
        {"McLaren", "mclaren"},
        {"Mercedes", "mercedes"},
        {"Red Bull", "red_bull"},
        {"Williams", "williams"}
    };

    public string GetConstructorID (string name)
    {
        try
        {
            return ConstructorIDs[name];
        }
        catch
        {
            return "No data";
        }
    }
}
