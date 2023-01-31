using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Fantasy;

public class FantasyLeagueModel
{
    public string LeagueId { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// League owner and choose to add security to a league by adding a password
    /// </summary>
    public bool RequirePassword { get; set; } = false;

    public string Password { get; set; } = string.Empty;

    public List<FantasyTeamModel>? Teams { get; set; }

    public string OwnerId { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }
}
