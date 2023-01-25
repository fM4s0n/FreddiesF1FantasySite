
namespace DataAccess.Models.Fantasy;


/// <summary>
/// A team entry represents a team at each race weekend in a season. 
/// since a team can chnage each race, this is used to track the team throughout the season, race by race.
/// </summary>
public class TeamRaceEntryModel
{
    public int TeamRaceEntryId { get; set; }

    public int Season { get; set; }

    public int TeamId { get; set; }

    public string ConstructorId { get; set; } = string.Empty;

    public double ConstructorPointsScored { get; set; }

    public string Driver1Id { get; set; } = string.Empty;

    public double Driver1PointsScored { get; set; }

    public string Driver2Id { get; set;} = string.Empty;

    public double Driver2PointsScored { get; set; }

    public string Driver3Id { get; set; } = string.Empty;

    public double Driver3PointsScored { get; set; }

    public string Driver4Id { get; set;} = string.Empty;

    public double Driver4PointsScored { get; set; }

    public string BoostedDriverId { get; set; } = string.Empty;
}
