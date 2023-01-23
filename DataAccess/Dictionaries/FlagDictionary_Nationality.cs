namespace DataAccess.Dictionaries;

public class FlagDictionary_Nationality
{
    private static readonly Dictionary<string, string> Nationalities = new()
    {
        {"American", "us"},
        {"Australian", "au"},
        {"Austrian", "at" },
        {"British", "gb"},
        {"Canadian", "ca"},
        {"Chinese", "cn"},
        {"Danish", "dk"},
        {"Dutch", "nl"},
        {"Finnish", "fi"},
        {"French", "fr"},
        {"German", "de"},
        {"Italian", "it"},
        {"Mexican", "mx"},
        {"Monegasque", "mc"},
        {"Japanese", "jp"},
        {"Spanish", "es"},
        {"Swiss", "ch"},
        {"Thai", "th"}
    };

    public static string ConvertNationality (string apiNationality)
    {
        try
        {
            return $"https://flagpedia.net/data/flags/w580/{Nationalities[apiNationality]}.png";
        }
        catch (Exception)
        {
            return "No data";
        }
    }
}
