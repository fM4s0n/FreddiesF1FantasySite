using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Fantasy;

public class FantasyLeagueModel
{
    public int LeagueId { get; set; }

    [Required]
    [StringLength(maximumLength: 30, ErrorMessage ="Name is too long, max length is 30 characters")]
    [MinLength(length: 5, ErrorMessage = "Name is too short, minimum length is 5 characters")]
    public string LeagueName { get; set; } = string.Empty;

    [Required]
    [StringLength(maximumLength: 30, ErrorMessage = "Password is too long, max length is 30 characters")]
    [MinLength(length: 5, ErrorMessage = "Password is too short, minimum length is 5 characters")]
    public string LeaguePassword { get; set; } = string.Empty;

    public List<FantasyTeamModel>? LeagueTeamsIds { get; set; }

    public int LeagueOwnerId { get; set; }
}
