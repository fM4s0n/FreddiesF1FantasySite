namespace DataAccess.Dictionaries.Fantasy;

public  class ConstructorValueDictionary
{
    private static readonly Dictionary<string, double> ConstructorValues = new()
    {
        {"Alfa Romeo", 8.0},
        {"AlphaTauri", 6.5},
        {"Alpine F1 Team", 18.0},
        {"Aston Martin", 7.0},
        {"Ferrari", 23.0},
        {"Haas F1 Team", 7.0},
        {"McLaren", 15.0},
        {"Mercedes", 25.0},
        {"Red Bull", 24.0},
        {"Williams", 5.0}
    };

    public static double GetCarImageURL (string ConstructorName)
    {
        try
        {
            return ConstructorValues[ConstructorName];
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
