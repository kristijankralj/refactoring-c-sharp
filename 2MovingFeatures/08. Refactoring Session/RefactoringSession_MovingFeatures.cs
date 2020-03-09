using System.Collections.Generic;

namespace MovingFeatures
{
    public class RefactoringSession_MovingFeatures
    {
        public class UserController
        {
            private IUserRepository _repository;

            internal SaveResult SaveNewUser(string id, string userName, string password, string confirmPassword)
            {
                var newUser = new User
                {
                    Id = id
                };

                if (CheckUserName(userName) == 0)
                {
                    return SaveResult.UserIsNotDefined;
                }
                else if (CheckUserName(userName) == -1)
                {
                    return SaveResult.UserExists;
                }
                else
                {
                    newUser.Username = userName;
                }

                if (password == "")
                {
                    return SaveResult.EmptyPassword;
                }
                else if (CheckPassword(password, confirmPassword))
                {
                    return SaveResult.PasswordsAreNotEqual;
                }
                else
                {
                    newUser.Password = password;
                }

                _repository.Save(newUser);
                return SaveResult.Success;
            }

            public int CheckUserName(string str)
            {
                if (str == "")
                {
                    return 0;
                }
                foreach (User per in _repository.AllUsers())
                {
                    if (per.Username == str)
                    {
                        return -1;
                    }
                }
                return 1;
            }

            public bool CheckPassword(string password, string confirmPassword)
            {
                if (password != confirmPassword)
                {
                    return false;
                }
                return true;
            }
        }
    }

    #region Other classes
    public enum SaveResult
    {
        UserExists,
        UserIsNotDefined,
        EmptyPassword,
        PasswordsAreNotEqual,
        DateIsNotCorrect,
        Success
    }

    public interface IUserRepository
    {
        IEnumerable<User> AllUsers();
        void Save(User user);
    }

    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    #endregion
}
