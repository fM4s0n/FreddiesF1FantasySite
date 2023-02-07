using DataAccess.Dictionaries;
using DataAccess.Dictionaries.Fantasy;

namespace DataAccess.Models.Fantasy;

/// <summary>
/// Tracks a driver for a specific team - due to boosts, 
/// a driver can score different points depending on the team they are a member of
/// </summary>
public class DriverTeamMembershipModel
{
    //id for db
    public string DriverTeamMembershipId { get; set; } = string.Empty;

    //id of associated team
    public string TeamId { get; set; } = string.Empty;

    //Api driver id
    public string DriverId { get; set; } = string.Empty;

    //Driver full name - dont store use dictionary
    public string DriverName { get { return DriverNameDictionary.GetDriverName(DriverId); } }

    //Which constructor the driver is currently driving for
    public string ConstructorId { get { return DriverConstructorIdDictionary.GetDriversConstructorId(DriverId); } }

    //Are they currenty on the team
    public bool CurrentlySelected { get; set; }

    //running total that this driver has scored for this team
    public double PointsScored { get; set; }

    //value purchased for
    public double PurchasedValue { get; set; }

    //current value - dont store, get from dictionary
    public double CurrentValue { get { return DriverValueDictionary.GetDriverValue(DriverId); } }

    //2 boosts per driver per season
    public int BoostsRemaining { get; set; } = 2;

    //Is the driver currently boosted
    public bool CurrentlyBoosted { get; set; } = false;
}
