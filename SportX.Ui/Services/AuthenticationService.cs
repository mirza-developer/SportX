namespace SportX.Ui.Services;

public static class AuthenticationService
{
    public static string Username = string.Empty;

    public static bool IsAdminAuthenticate(string username, string password)
    {
        if (!username.Equals("admin"))
        {
            return false;
        }

        if (!password.Equals("admingym")) 
        {
            return false;
        }

        Username = username;

        return true;
    }

    public static bool IsMaleUserAuthenticate(string username, string password)
    {
        if (!username.Equals("man"))
        {
            return false;
        }

        if (!password.Equals("manadmin"))
        {
            return false;
        }

        Username = username;

        return true;
    }

    public static bool IsFemaleUserAuthenticate(string username, string password)
    {
        if (!username.Equals("woman"))
        {
            return false;
        }

        if (!password.Equals("adminWoman"))
        {
            return false;
        }

        Username = username;

        return true;
    }
}
