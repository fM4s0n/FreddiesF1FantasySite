namespace DataAccess.Models.Fantasy;

/// <summary>
/// Tracks a driver for a specific team - due to boosts, 
/// a driver can score different points depending on the team they are a member of
/// </summary>
public class DriverTeamMembership
{
    public string DriverTeamMembershipId { get; set; } = string.Empty;

    public string TeamId { get; set; } = string.Empty;

    //Api driver id
    public string DriverId { get; set; } = string.Empty;

    public bool CurrentlySelected { get; set; }

    public double PointsScoredForTeam { get; set; }

    public double PurchasedValue { get; set; }

    public double CurrentValue { get; set; }
}
