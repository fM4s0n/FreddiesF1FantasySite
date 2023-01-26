namespace DataAccess.Models.Fantasy;

/// <summary>
/// Tracks a driver for a specific team - due to boosts, 
/// a driver can score different points depending on the team they are a member of
/// </summary>
public class DriverTeamMembership
{
    public int DriverTeamMembershipId { get; set; }

    public int TeamId { get; set; }

    public string DriverId { get; set; } = string.Empty;

    public bool CurrentlySelected { get; set; }

    public int PointsScoredForTeam { get; set; }
    public double PurchasedValue { get; set; }
}
