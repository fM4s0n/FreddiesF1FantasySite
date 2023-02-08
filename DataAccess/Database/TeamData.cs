using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

/// <summary>
/// Database queries for team based queries
/// </summary>
public class TeamData : ITeamData
{
    private readonly ISqlDataAccess _db;

    public TeamData(ISqlDataAccess db)
    {
        _db = db;
    }


    /// <summary>
    /// Get all teams
    /// </summary>
    /// <returns>List of every team</returns>
    public Task<List<FantasyTeamModel>> GetAllTeams()
    {
        string sql = "SELECT * FROM tblTeam";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }


    /// <summary>
    /// Get list of teams by their userId
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>List of all teams owned by a user</returns>
    public Task<List<FantasyTeamModel>> GetTeamsByUserId(string userId)
    {
        string sql = "SELECT * FROM tblTeam WHERE UserId = @userId";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyTeamModel>> GetTeamsByLeagueId(string leagueId)
    {
        string sql = "SELECT * FROM dbo.Team WHERE LeagueId = @leagueId";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyTeamModel>> GetTeamByTeamId(string teamId)
    {
        string sql = "SELECT * FROM dbo.Team WHERE TeamId = @teamId";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    /// <summary>
    /// get the most recent team inserted to the db
    /// </summary>
    /// <returns></returns>
    public Task<List<FantasyTeamModel>> GetMostRecentTeam(int userId)
    {
        string sql = "SELECT TOP 1 * FROM tblTeam WHERE UserId = @userId ORDER BY TeamId DESC";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    /// <summary>
    /// Add a new team to the db
    /// </summary>
    /// <param name="team"></param>
    /// <returns></returns>
    public Task InsertTeam(FantasyTeamModel team)
    {
        string sql = @"INSERT INTO dbo.tblTeam 
                       VALUES (@TeamId, @Name, @OwnerId, @LeagueId, @BudgetRemaining, @CreatedDate, @TeamChangesCompleted, @BoostedDriverId);";

        return _db.SaveData(sql, team);
    }

    /// <summary>
    /// Update deatils of a team in the db
    /// </summary>
    /// <param name="team"></param>
    /// <returns></returns>
    public Task UpdateTeamDetails(FantasyTeamModel team)
    {
        string sql = @"UPDATE dbo.tblTeam SET 
                       Name = @team.Name, OwenerId = @OwnerId, LeagueId = @LeagueId, BudgetRemaining = @BudgetRemaining,
                       TeamChangedCompleted = @TeamChangesCompleted, BoostedDriverId = @BoostedDriverId
                       WHERE TeamId = @team.TeamId";

        return _db.SaveData(sql, team);
    }
}
