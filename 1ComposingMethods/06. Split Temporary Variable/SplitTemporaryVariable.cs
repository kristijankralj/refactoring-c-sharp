using System.Threading.Tasks;

namespace ComposingMethods
{
    #region Other Classes

    public class IdentityResult
    {
        public bool Succeeded { get; set; }
    }

    public class ModelState
    {
        public static bool IsValid { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }
    }

    public class UserManager
    {
        public static User FindById(int userId)
        {
            return new User(userId);
        }

        public static Task<IdentityResult> ChangePasswordAsync(User user, string password)
        {
            //TODO change password
            return null;
        }
    }

    #endregion

    public class SplitTemporaryVariable
    {
        public async Task<bool> ManagePassword(int userId, string newPassword)
        {
            bool hasUserCorrectPassword = UserManager.FindById(userId).Password != null;
            if (hasUserCorrectPassword)
            {
                if (ModelState.IsValid)
                {
                    IdentityResult result = await UserManager.ChangePasswordAsync(UserManager.FindById(userId), newPassword);
                    if (result.Succeeded)
                    {
                        result = PrepareResponseMessage("All changes have been saved.");
                        return result.Succeeded;
                    }
                    else
                    {
                        AddErrors(result);
                        return false;
                    }
                }
            }
            return false;
        }

        private IdentityResult PrepareResponseMessage(string action)
        {
            //TODO redirect
            return null;
        }

        private IdentityResult AddErrors(IdentityResult result)
        {
            //TODO log errors
            return null;
        }
    }
}
