using DataAccess.Models;

namespace DataAccess.Services;

public class AppStateService
{
    public bool isLoggedIn = false;
    public UserModel currentUser = new();

    public void LogIn (UserModel user)
    {
        isLoggedIn = true;
        currentUser = user;
    }

    public void LogOut ()
    {
        isLoggedIn = false;
        currentUser = new();
    }
}
