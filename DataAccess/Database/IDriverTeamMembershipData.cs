using DataAccess.Models.Fantasy;

namespace DataAccess.Database
{
    public interface IDriverTeamMembershipData
    {
        Task<List<DriverTeamMembershipModel>> GetAllDriverTeamMemberships();
        Task InsertDriverTeamMembership(DriverTeamMembershipModel dtm);
        Task UpdateDriverTeamMembership(DriverTeamMembershipModel dtm);
    }
}