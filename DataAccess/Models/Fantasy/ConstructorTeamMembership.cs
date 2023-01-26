namespace DataAccess.Models.Fantasy;

public class ConstructorTeamMembership
{
    public int ConstructorTeamMembershipId { get; set; }

    public int TeamId { get; set; }

    //Api driver id
    public string ConstructorId { get; set; } = string.Empty;

    public bool CurrentlySelected { get; set; }

    public int PointsScoredForTeam { get; set; }

    public double PurchasedValue { get; set; }

    public double CurrentValue { get; set; }
}
