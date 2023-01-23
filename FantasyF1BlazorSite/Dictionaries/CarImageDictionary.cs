namespace FreddiesF1FantasySite.Dictionaries;

internal class CarImageDictionary
{
    private static readonly Dictionary<string, string> CarImageURLs = new()
    {
        {"Alfa Romeo", "https://www.formula1.com/content/dam/fom-website/teams/2023/alfa-romeo.png.transform/4col/image.png"},
        {"AlphaTauri", "https://www.formula1.com/content/dam/fom-website/teams/2023/alphatauri.png.transform/4col/image.png"},
        {"Alpine F1 Team", "https://www.formula1.com/content/dam/fom-website/teams/2023/alpine.png.transform/4col/image.png"},
        {"Aston Martin", "https://www.formula1.com/content/dam/fom-website/teams/2023/aston-martin.png.transform/4col/image.png"},
        {"Ferrari", "https://www.formula1.com/content/dam/fom-website/teams/2023/ferrari.png.transform/4col/image.png"},
        {"Haas F1 Team", "https://www.formula1.com/content/dam/fom-website/teams/2023/haas-f1-team.png.transform/4col/image.png"},
        {"McLaren", "https://www.formula1.com/content/dam/fom-website/teams/2023/mclaren.png.transform/4col/image.png"},
        {"Mercedes", "https://www.formula1.com/content/dam/fom-website/teams/2023/mercedes.png.transform/4col/image.png"},
        {"Red Bull", "https://www.formula1.com/content/dam/fom-website/teams/2023/red-bull-racing.png.transform/4col/image.png"},
        {"Williams", "https://www.formula1.com/content/dam/fom-website/teams/2023/williams.png.transform/4col/image.png"}
    };

    public static string GetCarImageURL (string apiConstructorName)
    {
        try
        {
            return CarImageURLs[apiConstructorName];
        }
        catch (Exception)
        {
            return "No data";
        }
    }
}
