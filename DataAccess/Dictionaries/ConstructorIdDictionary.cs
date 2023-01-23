namespace DataAccess.Dictionaries;

public class ConstructorIdDictionary
{
    private static readonly Dictionary<string, string> ConstructorIDs = new()
    {
        {"Alfa Romeo", "alfa"},
        {"Mercedes", "mercedes"},
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
