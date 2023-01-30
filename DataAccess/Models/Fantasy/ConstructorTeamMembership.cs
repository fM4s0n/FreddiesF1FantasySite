namespace DataAccess.Models.Fantasy;

public class ConstructorTeamMembership
{
    public string ConstructorTeamMembershipId { get; set; } = string.Empty;

    public string TeamId { get; set; } = string.Empty;

    //Api driver id
    public string ConstructorId { get; set; } = string.Empty;

    public bool CurrentlySelected { get; set; }

    public double PointsScoredForTeam { get; set; }

    public double PurchasedValue { get; set; }

    public double CurrentValue { get; set; }
}
