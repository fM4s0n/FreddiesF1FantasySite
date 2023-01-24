using DataAccess.Models;

namespace DataAccess.Database;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData (ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<UserModel>> GetAllUsers ()
    {
        string sql = "SELECT * FROM tblUser";

        return _db.LoadData<UserModel, dynamic>(sql, new { });
    }

    public Task<List<UserModel>> GetUser (string Username)
    {
        string sql = "SELECT * FROM tblUser WHERE Username = '@Username' ";

        return _db.LoadData<UserModel, dynamic>(sql, new { });
    }

    public Task InsertUser (UserModel user)
    {
        string sql = @"INSERT INTO dbo.tblUser (Username, Password, FullName, FavouriteDriverId, FavouriteConstructorId, FavouriteDriverName, FavouriteConstructorName)
                       VALUES (@Username, @Password, @FullName, @FavouriteDriverId, @FavouriteConstructorId, @FavouriteDriverName, @FavouriteConstructorName);";

        return _db.SaveData(sql, user);
    }

    public Task UpdateUserDetails (UserModel user)
    {
        string sql = @"UPDATE dbo.tblUser SET Username = @Username, Password = @Password, FullName = @FullName,
                       FavouriteDriverId = @FavouriteDriverId, FavouriteConstructorId = @FavouriteConstructorId,
                       FavouriteDriverName = @FavouriteDriverName, FavouriteConstructorName = @FavouriteConstructorName
                       WHERE Username = @Username";

        return _db.SaveData(sql, user);
    }
}
