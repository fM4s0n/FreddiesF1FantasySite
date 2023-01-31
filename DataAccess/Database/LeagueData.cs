using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

public class LeagueData : ILeagueData
{
    private readonly ISqlDataAccess _db;

    public LeagueData (ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<FantasyLeagueModel>> GetAllLeagues ()
    {
        string sql = "SELECT * FROM tblLeague";

        return _db.LoadData<FantasyLeagueModel, dynamic>(sql, new { });
    }

    public Task<List<FantasyLeagueModel>> GetLeaguesByUserId (string userId)
    {
        throw new NotImplementedException();
    }

    public Task InsertLeague(FantasyLeagueModel league)
    {
        string sql = @"INSERT INTO dbo.tblLeague 
                       VALUES (LeagueId = @LeagueId, Name = @Name, RequirePassword = @RequirePassword, Password = @Password, , OwnerId = @OwnerId, CreatedDate = @CreatedDate);";

        return _db.SaveData(sql, league);
    }

    public Task UpdateLeagueDetails(FantasyLeagueModel league)
    {
        string sql = @"UPDATE dbo.tblLeague SET Name = @league.Name, Password = @league.Password, OwnerId = @league.OwnerId
                       WHERE LeagueId = @league.LeagueId";

        return _db.SaveData(sql, league);
    }
}

