namespace DataAccess.Models.Fantasy;

public class FantasyLeagueModel
{
    public int LeagueId { get; set; }

    public string LeagueName { get; set; } = string.Empty;

    public string LeaguePassword { get; set; } = string.Empty;

    public List<FantasyTeamModel>? LeagueTeamsIds { get; set; }

    public int LeagueOwnerId { get; set; }
}
