namespace DataAccess.Models.Fantasy;

public class FantasyLeagueModel
{
    public int LeagueId { get; set; }

    public string LeagueName { get; set; } = "";

    public List<FantasyTeamModel>? LeagueTeamsIds { get; set; }

    public int LeagueOwnerId { get; set; }

}
