using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

public class LeagueData : ILeagueData
{
    private readonly ISqlDataAccess _db;

    public LeagueData (ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<FantasyLeagueModel>> GetAllLeagues()
    {
        string sql = "SELECT * FROM tblLeague";

        return _db.LoadData<FantasyLeagueModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyLeagueModel>> GetLeague(int leagueId)
    {
        string sql = "SELECT * FROM tblLeague WHERE LeagueId = @leagueId";

        return _db.LoadData<FantasyLeagueModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyLeagueModel>> GetMostRecentLeague()
    {
        string sql = "SELECT TOP 1 * FROM tblLeague ORDER BY LeagueId DESC";

        return _db.LoadData<FantasyLeagueModel, dynamic>(sql, new { });
    }


    public Task InsertLeague(FantasyLeagueModel league)
    {
        string sql = @"INSERT INTO dbo.tblLeague 
                       VALUES (Name = @league.Name, Password = @league.Password, CreatedDate = @league.CreatedDate, OwnerId = @league.OwnerId);";

        return _db.SaveData(sql, league);
    }

    public Task UpdateLeagueDetails(FantasyLeagueModel league)
    {
        string sql = @"UPDATE dbo.tblLeague SET Name = @league.Name, Password = @league.Password, OwnerId = @league.OwnerId
                       WHERE LeagueId = @league.LeagueId";

        return _db.SaveData(sql, league);
    }
}

