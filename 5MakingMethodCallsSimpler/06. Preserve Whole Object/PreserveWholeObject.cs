using System;
namespace MakingMethodCallsSimpler
{
    public class PreserveWholeObject
    {
        public interface Database
        {
            void SaveUser(string userName, string password, string email);
        }

        public class UserModel
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

        public class User
        {
            public string UserName { get; set; }
            public string Email { get; set; }
        }

        public class AuthService
        {
            private static Database _database;

            public static User CreateUser(string userName, string password, string email)
            {
                _database.SaveUser(userName, password, email);
                return new User { Email = email, UserName = password };
            }
        }

        public User RegisterUser(UserModel model)
        {
            User newUser = null;

            try
            {
                newUser = AuthService.CreateUser(model.UserName, model.Password, model.Email);
            }
            catch(InsufficientMemoryException)
            {
                throw;
            }
            catch(Exception ex)
            {
                LogError(ex);
            }
            return newUser;
        }

        #region Other methods
        private void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
