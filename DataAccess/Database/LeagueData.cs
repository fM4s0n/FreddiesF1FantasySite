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

    public Task<List<FantasyLeagueModel>> GetLeaguesByUserId(string OwnerId)
    {
        string sql = "SELECT * FROM tblLeague WHERE OwnerId = @OwnerId";

        return _db.LoadData<FantasyLeagueModel, dynamic>(sql, new { });
    }

    public Task InsertLeague(FantasyLeagueModel league)
    {
        string sql = @"INSERT INTO dbo.tblLeague (LeagueId, Name, RequirePassword, Password, OwnerId, CreatedDate)
                       VALUES (@LeagueId, @Name, @RequirePassword, @Password, @OwnerId, @CreatedDate);";

        return _db.SaveData(sql, league);
    }

    public Task UpdateLeagueDetails(FantasyLeagueModel league)
    {
        string sql = @"UPDATE dbo.tblLeague SET Name = @league.Name, Password = @league.Password, OwnerId = @league.OwnerId
                       WHERE LeagueId = @league.LeagueId";

        return _db.SaveData(sql, league);
    }
}

