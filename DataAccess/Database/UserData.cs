using DataAccess.Models;

namespace DataAccess.Database;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData (ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<UserModel>> GetUsers ()
    {
        string sql = "SELECT * FROM tblUser";

        return _db.LoadData<UserModel, dynamic>(sql, new { });
    }

    public Task InsertUser (UserModel user)
    {
        string sql = @"INSERT INTO tblUser((Username, Password, FullName, FavouriteDriverId, FavouriteConstructorId)
                       VALUES(@Username, @Password, @FullName, @FavouriteDriverId, @FavouriteConstructorId);";

        return _db.SaveData(sql, user);
    }
}
