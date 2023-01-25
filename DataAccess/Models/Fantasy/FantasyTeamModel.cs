namespace DataAccess.Models.Fantasy;


//only store ids in the table. user tha id to then read a different table in the db to get the rest of the info to populate the object


/// <summary>
/// Model for a user's fantasy team
/// </summary>
public class FantasyTeamModel
{
    public int FantasyTeamId { get; set; } = 0;

    public string FantasyTeamName { get; set; } = string.Empty;

    public int TeamOwnerUserId { get; set; } = 0;

    public string ConstructorId { get; set; } = string.Empty;

    public string Driver1Id { get; set; } = string.Empty;

    public string Driver2Id { get; set; } = string.Empty;

    public string Driver3Id { get; set; } = string.Empty;

    public string Driver4Id { get; set; } = string.Empty;

    public string BoostedDriverId { get; set; } = string.Empty;

    public double TeamBudgetRemaining { get; set; } = 100.0;

    public double TeamValue { get; set; } = 0;
}
