using DataAccess.Models.Fantasy;

namespace DataAccess.Database
{
    public interface IConstructorTeamMembershipData
    {
        Task<List<ConstructorTeamMembershipModel>> GetAllConstructorTeamMemberships();
        Task InsertConstructorTeamMembership(ConstructorTeamMembershipModel ctm);
        Task UpdateConstructorTeamMembership(ConstructorTeamMembershipModel ctm);
    }
}