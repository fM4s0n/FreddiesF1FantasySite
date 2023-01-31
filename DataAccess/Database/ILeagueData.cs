using DataAccess.Models.Fantasy;

namespace DataAccess.Database
{
    public interface ILeagueData
    {
        Task<List<FantasyLeagueModel>> GetAllLeagues ();
        Task<List<FantasyLeagueModel>> GetLeaguesByUserId(string userId);
        Task InsertLeague(FantasyLeagueModel league);
        Task UpdateLeagueDetails(FantasyLeagueModel league);
    }
}