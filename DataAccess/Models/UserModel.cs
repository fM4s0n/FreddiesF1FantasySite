using DataAccess.Dictionaries;

namespace DataAccess.Models;

/// <summary>
/// 
/// </summary>
public class UserModel
{
    public string UserId { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public UserLevels UserLevel { get; set; } = UserLevels.Standard;

    public string FavouriteDriverName { get; set; } = string.Empty;

    public string FavouriteDriverId { get; set; } = string.Empty;

    public string FavouriteConstructorName { get; set; } = string.Empty;

    public string FavouriteConstructorId { get; set; } = string.Empty;

}

/// <summary>
/// 
/// </summary>
public enum UserLevels
{
    Standard,
    Pro,
    Administrator
}