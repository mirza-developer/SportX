namespace SportX.Ui.Parking.Services;

public static class AuthenticationService
{
    public static string Username = string.Empty;

    public static bool IsAdminAuthenticate(string username, string password)
    {
        if (!username.Equals("admin"))
        {
            return false;
        }

        if (!password.Equals("adminparking")) 
        {
            return false;
        }

        Username = username;

        return true;
    }
}
