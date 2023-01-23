using DataAccess.Models;

namespace DataAccess.Database;

public class DatabaseService
{
    public async Task<List<UserModel>> GetUsersAsync ()
    {
        List<UserModel> users = new();
        return users;
    }

    public async Task<UserModel> CreateUserAsync (UserModel user)
    {
        return user;
    }

    public async Task<UserModel> UpdateUserAsync (UserModel user)
    {
        return user;
    }

    public async Task<UserModel> DeleteUserAsync (UserModel user)
    {
        return user;
    }
}
