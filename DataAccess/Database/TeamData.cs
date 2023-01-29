using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

public class TeamData
{
    private readonly ISqlDataAccess _db;

    public TeamData (ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<FantasyTeamModel>> GetAllLeagues ()
    {
        string sql = "SELECT * FROM tblTeam";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    //might need chnage this to get by user Id then list for user to pick
    public Task<List<FantasyTeamModel>> GetLeague (int teamId)
    {
        string sql = "SELECT * FROM tblTeam WHERE TeamId = @teamId";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyTeamModel>> GetMostRecentLeague ()
    {
        string sql = "SELECT TOP 1 * FROM tblTeam ORDER BY TeamId DESC";

        return _db.LoadData<FantasyTeamModel, dynamic>(sql, new { });
    }


    public Task InsertLeague (FantasyTeamModel team)
    {
        string sql = @"INSERT INTO dbo.tblTeam 
                       VALUES (@, @, @, @, @, @, @);";

        return _db.SaveData(sql, team);
    }

    public Task UpdateLeagueDetails (FantasyTeamModel team)
    {
        string sql = @"UPDATE dbo.tblTeam SET TeamName = @team.LeagueName,
                       WHERE TeamId = @team.TeamId";

        return _db.SaveData(sql, team);
    }
}
