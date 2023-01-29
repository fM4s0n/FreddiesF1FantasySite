using DataAccess.Models.Fantasy;

namespace DataAccess.Database
{
    public interface ILeagueData
    {
        Task<List<FantasyLeagueModel>> GetAllLeagues();
        Task<List<FantasyLeagueModel>> GetLeague(int leagueId);
        Task<List<FantasyLeagueModel>> GetMostRecentLeague();
        Task InsertLeague(FantasyLeagueModel league);
        Task UpdateLeagueDetails(FantasyLeagueModel league);
    }
}