using DataAccess.Models.Fantasy;

namespace DataAccess.Database;

public class ConstructorTeamMembershipData : IConstructorTeamMembershipData
{
    private readonly ISqlDataAccess _db;

    public ConstructorTeamMembershipData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<ConstructorTeamMembershipModel>> GetAllConstructorTeamMemberships()
    {
        string sql = "SELECT * FROM dbo.tblConstructorTeamMembership";

        return _db.LoadData<ConstructorTeamMembershipModel, dynamic>(sql, new { });
    }

    public Task InsertConstructorTeamMembership(ConstructorTeamMembershipModel ctm)
    {
        string sql = @"INSERT INTO dbo.tblConstructorTeamMembership (ConstructorTeamMembershipId, TeamId, ConstructorId, PointsScored, PurchasedValue)
                       VALUES(@ConstructorTeamMembershipId, @TeamId, @ConstructorId, @CurrentlySelected, @PointsScored, @PurchasedValue)";

        return _db.SaveData(sql, ctm);
    }

    public Task UpdateConstructorTeamMembership(ConstructorTeamMembershipModel ctm)
    {
        string sql = @"UPDATE dbo.tblConstructorTeamMembership SET ConstructorTeamMembershipId = @ConstructorTeamMembershipId, 
                       TeamId = @TeamId, ConstructorId = @ConstructorId, CurrentlySelected = @CurrentlySelected,
                       PointsScored = @PointsScored, PurchasedValue = @PurchasedValue";

        return _db.SaveData(sql, ctm);
    }
}
