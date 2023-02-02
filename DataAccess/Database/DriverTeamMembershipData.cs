using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

public class DriverTeamMembershipData : IDriverTeamMembershipData
{
    private readonly ISqlDataAccess _db;

    public DriverTeamMembershipData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<DriverTeamMembershipModel>> GetAllDriverTeamMemberships()
    {
        string sql = "SELECT * FROM dbo.tblDriverTeamMembership";

        return _db.LoadData<DriverTeamMembershipModel, dynamic>(sql, new { });
    }

    public Task InsertDriverTeamMembership(DriverTeamMembershipModel dtm)
    {
        string sql = @"INSERT INTO dbo.tblDriverTeamMembership 
                       VALUES(@DriverTeamMembershipId, @TeamId, @DriverId, @CurrentlySelected, @PointsScored, @PurchasedValue)";

        return _db.SaveData(sql, dtm);
    }

    public Task UpdateDriverTeamMembership(DriverTeamMembershipModel dtm)
    {
        string sql = @"UPDATE dbo.tblDriverTeamMembership SET DriverTeamMembershipId = @DriverTeamMembershipId, 
                       TeamId = @TeamId, DriverId = @DriverId, CurrentlySelected = @CurrentlySelected,
                       PointsScored = @PointsScored, PurchasedValue = @PurchasedValue";

        return _db.SaveData(sql, dtm);
    }
}
