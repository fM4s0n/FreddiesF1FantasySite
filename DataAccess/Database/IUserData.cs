using DataAccess.Models;

namespace DataAccess.Database
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUsers ();
        Task InsertUser (UserModel user);
    }
}