using FreddiesF1FantasySite.Dictionaries;
using FreddiesF1FantasySite.Models;

namespace FreddiesF1FantasySite.Models;

public class UserModel
{
    private readonly DriverIdDictionary driverIdDictionary = new();
    private readonly ConstructorIdDictionary constructorIdDictionary = new();

    public int UserID { get; set; }
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Name { get; set; } = "";
    public string FavouriteDriver { get; set; } = "";
    public string FavouriteDriverId
    {
        get { return driverIdDictionary.GetDriverId(FavouriteDriver); }
    }
    public string FavouriteConstructor { get; set; } = "";
    public string FavouriteConstructorId
    {
        get { return constructorIdDictionary.GetConstructorID(FavouriteConstructor); }
    }

    //public List<FantasyF1LeagueMembership> FantasyLeagueMemberships { get; set; }
}
