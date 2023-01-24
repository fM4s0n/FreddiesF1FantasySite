using DataAccess.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Database;

public class DatabaseService
{
    private readonly IConfiguration _config;

    public string ConnectionStringName { get; set; } = "Default";

    public DatabaseService(IConfiguration config) 
    { 
        _config = config;
    }

    public async Task<List<UserModel>> GetUsersAsync ()
    {
        string connectionString = _config.GetConnectionString(ConnectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            var data = await connection
        }

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
