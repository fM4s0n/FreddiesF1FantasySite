namespace DataAccess.Models.Fantasy;


//only store ids in the table. user tha id to then read a different table in the db to get the rest of the info to populate the object


/// <summary>
/// Model for a user's fantasy team
/// </summary>
public class FantasyTeamModel
{
    public int TeamId { get; set; }

    public string TeamName { get; set; } = string.Empty;

    //UserId of who owns the Team
    public int OwnerId { get; set; }

    public UserModel? Owner { get; set; }

    //LeagueId of the league a team is associated with - can be null incase they get kicked from a league
    public int? LeagueId { get; set; }

    public List<ConstructorTeamMembership>? Constructors { get; set; }
    
    public List<DriverTeamMembership>? Drivers { get; set; }

    public string BoostedDriverId { get; set; } = string.Empty;

    public double TeamBudgetRemaining { get; set; } = 100.0;

    public double TeamValue { get; set; }

    public double TeamPoints { get; set; }
}
