using DataAccess.Dictionaries;

namespace DataAccess.Models;

/// <summary>
/// 
/// </summary>
public class UserModel
{
    public Guid UserId { get; set; }

    public string StrUserId { get { return UserId.ToString(); } }

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public AccountLevels AccountLevel { get; set; } = AccountLevels.Standard;

    public string FavouriteDriverName { get; set; } = string.Empty;

    public string FavouriteDriverId { get; set; } = string.Empty;

    public string FavouriteConstructorName { get; set; } = string.Empty;

    public string FavouriteConstructorId { get; set; } = string.Empty;

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