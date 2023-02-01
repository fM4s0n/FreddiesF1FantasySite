namespace DataAccess.Dictionaries;

public class ConstructorNameDictionary
{
    private static readonly Dictionary<string, string> ConstructorNames = new()
    {
        {"alfa", "Alfa Romeo"},
        {"alphatauri", "AlphaTauri"},
        {"alpine" , "Alpine F1 Team"},
        {"aston_martin" , "Aston Martin"},
        {"ferrari", "Ferrari"},
        {"haas" , "Haas F1 Tea,"},
        {"mclaren" , "McLaren"},
        {"mercedes" , "Mercedes"},
        {"red_bull" , "Red Bull"},
        {"williams" , "Williams"}
    };

    public string GetConstructorID(string id)
    {
        try
        {
            return ConstructorNames[id];
        }
        catch
        {
            return "No data";
        }
    }
}
