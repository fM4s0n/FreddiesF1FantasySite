using DataAccess.Models;

namespace DataAccess.Database
{
    public interface IUserData
    {
        Task<List<UserModel>> GetAllUsers ();
        Task<List<UserModel>> GetUser (string Username);
        Task InsertUser (UserModel user);
    }
}