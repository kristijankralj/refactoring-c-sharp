using System.Collections.Generic;

namespace SimplifyingConditional
{
    public class LoginMessage
    {
        public string Message { get; set; }
        public bool LoginStatus { get; set; }

        public LoginMessage(string message, bool status)
        {
            Message = message;
            LoginStatus = status;
        }
    }

    public class Login
    {
        private int loginAttempts = 3;
        private Dictionary<string, string> allowedUsers = new Dictionary<string, string>
        {
            { "admin", "8vYhN#Bp0h^p" },
            { "poweruser", "bH6s0U!8p9Ze" },
            { "superadmin", "y87QqoiG1Vz*" }
         };

        public LoginMessage PerformLogin(string username, string password)
        {
            if (loginAttempts > 0)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    loginAttempts--;
                    return new LoginMessage("Username or password is empty.", false);
                }

                else if (!allowedUsers.ContainsKey(username))
                {
                    loginAttempts--;
                    return new LoginMessage("Incorrect username or password.", false);
                }
                else if (allowedUsers[username] != password)
                {
                    loginAttempts--;
                    return new LoginMessage("Incorrect username or password.", false);
                }

                return new LoginMessage("Login succesful", true);
            }
            return new LoginMessage("No more login attempts left.", false);
        }
    }
}
