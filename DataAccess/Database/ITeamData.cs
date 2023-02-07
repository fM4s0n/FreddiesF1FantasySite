using DataAccess.Models.Fantasy;

namespace DataAccess.Database
{
    public interface ITeamData
    {
        Task<List<FantasyTeamModel>> GetAllTeams();
        Task<List<FantasyTeamModel>> GetMostRecentTeam(int userId);
        Task<List<FantasyTeamModel>> GetTeamsByLeagueId(string leagueId);
        Task<List<FantasyTeamModel>> GetTeamsByUserId(string userId);
        Task InsertTeam(FantasyTeamModel team);
        Task UpdateTeamDetails(FantasyTeamModel team);
    }
}