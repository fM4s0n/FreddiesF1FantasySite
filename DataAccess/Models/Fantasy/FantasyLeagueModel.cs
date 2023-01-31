using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Fantasy;

public class FantasyLeagueModel
{
    public string LeagueId { get; set; } = string.Empty;

    [Required]
    [StringLength(maximumLength: 30, ErrorMessage ="Name is too long, max length is 30 characters")]
    [MinLength(length: 5, ErrorMessage = "Name is too short, minimum length is 5 characters")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// League owner and choose to add security to a league by adding a password
    /// </summary>
    public bool RequirePassword = false;

    [Required]
    [StringLength(maximumLength: 30, ErrorMessage = "Password is too long, max length is 30 characters")]
    [MinLength(length: 5, ErrorMessage = "Password is too short, minimum length is 5 characters")]
    public string Password { get; set; } = string.Empty;

    public List<FantasyTeamModel>? Teams { get; set; }

    public string OwnerId { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }
}
