namespace DataAccess.Models.Fantasy;


//only store ids in the table. user tha id to then read a different table in the db to get the rest of the info to populate the object


/// <summary>
/// Model for a user's fantasy team
/// </summary>
public class FantasyTeamModel
{
    public int FantasyTeamId { get; set; }

    public string FantasyTeamName { get; set; } = string.Empty;

    //UserId of who owns the Team
    public int OwnerUserId { get; set; }

    public UserModel? Owner { get; set; }

    //LeagueId of the league a team is associated with
    public int LeagueId { get; set; }
    
    //Api Constructor Id 
    public string ConstructorId { get; set; } = string.Empty;

    //Api driver id
    public string Driver1Id { get; set; } = string.Empty;

    //Value of driver at time of purchase
    public double Driver1PurchasedValue { get; set; }

    //Total points score by the driver for this team
    public double Driver1Points { get; set; }

    public string Driver2Id { get; set; } = string.Empty;

    public double Driver2PurchasedValue { get; set; }

    public double Driver2Points { get; set; }

    public string Driver3Id { get; set; } = string.Empty;

    public double Driver3PurchasedValue { get; set; }

    public double Driver3Points { get; set; }

    public string Driver4Id { get; set; } = string.Empty;

    public double Driver4PurchasedValue { get; set; }

    public double Driver4Points { get; set; }

    public string BoostedDriverId { get; set; } = string.Empty;

    public double TeamBudgetRemaining { get; set; } = 100.0;

    public double TeamValue { get; set; }

    public double TeamPoints { get; set; }
}
