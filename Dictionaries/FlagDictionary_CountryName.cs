namespace FreddiesF1FantasySite.Dictionaries;

internal class FlagDictionary_CountryName
{
    private static readonly Dictionary<string, string> Countries = new()
    {
        {"Australia", "au"},
        {"Austria", "at"},
        {"Azerbaijan", "az"},
        {"Bahrain", "bh"},
        {"Belgium", "be"},
        {"Brazil", "br"},
        {"Canada", "ca"},
        {"Hungary", "hu"},
        {"Italy", "it"},
        {"Japan", "jp"},
        {"Mexico", "mx"},
        {"Monaco", "mc"},
        {"Netherlands", "nl"},
        {"Qatar", "qa"},
        {"Saudi Arabia", "sa" },
        {"Singapore", "sg" },
        {"Spain", "es"},
        {"UAE", "ae"},
        {"UK", "gb"},
        {"United States", "us"},
        {"USA", "us"}
    };

    public static string ConvertCountryName (string apiCountryName)
    {
        try
        {
            return $"https://flagpedia.net/data/flags/w580/{Countries[apiCountryName]}.png";
        }
        catch
        {
            return "No data";
        }
    }
}
