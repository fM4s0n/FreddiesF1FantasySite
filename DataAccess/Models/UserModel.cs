using DataAccess.Dictionaries;

namespace DataAccess.Models;

/// <summary>
/// 
/// </summary>
public class UserModel
{
    public int UserID { get; set; }

    public string Username { get; set; } = "";

    public string Password { get; set; } = "";

    public string FullName { get; set; } = "";

    public AccountLevels AccountLevel { get; set; } = AccountLevels.Standard;

    public string FavouriteDriverName { get; set; } = "";

    public string FavouriteDriverId { get; set; } = "";

    public string FavouriteConstructorName { get; set; } = "";

    public string FavouriteConstructorId { get; set; } = "";
}

/// <summary>
/// 
/// </summary>
public enum AccountLevels
{
    Standard,
    Pro,
    Administrator
}