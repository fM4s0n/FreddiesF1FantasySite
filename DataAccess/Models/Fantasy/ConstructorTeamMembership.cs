using DataAccess.Dictionaries;
using DataAccess.Dictionaries.Fantasy; 

namespace DataAccess.Models.Fantasy;

public class ConstructorTeamMembership
{
    //id for db
    public string ConstructorTeamMembershipId { get; set; } = string.Empty;

    //id of associated team
    public string TeamId { get; set; } = string.Empty;

    //Api driver id
    public string ConstructorId { get; set; } = string.Empty;

    //Driver full name - dont store use dictionary
    public string ConstructorName { get { return ConstructorNameDictionary.GetConstructorName(ConstructorId); } }

    //Are they currenty on the team
    public bool CurrentlySelected { get; set; }

    //running total that this constructor has scored for this team
    public double PointsScored { get; set; }

    //value purchased for
    public double PurchasedValue { get; set; }

    //current value - dont store, get from dictionary
    public double CurrentValue { get { return ConstructorValueDictionary.GetCurrentValue(ConstructorId); } }
}
