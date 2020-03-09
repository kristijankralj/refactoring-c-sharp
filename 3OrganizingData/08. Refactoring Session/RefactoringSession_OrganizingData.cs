using System;
using System.Collections.Generic;

namespace OrganizingData
{
    public class RefactoringSession_OrganizingData
    {
        class User
        {
            private int _type;

            public User(int type)
            {
                _type = type;
            }

            public string Name { get; set; }
            public string Email { get; set; }
            public string UserName { get; set; }

            public List<string> GetPermissions()
            {
                return _type switch
                {
                    1 => new List<string> { "seeAssets", "modifyAssets", "seeLabels", "modifyLabels" },
                    2 => new List<string> { "seeAssets", "modifyAssets", "seeLabels", "modifyLabels", "getReport", "settings" },
                    3 => new List<string> { "seeAssets", "seeLabels" },
                    _ => throw new Exception("Unknown type"),
                };
            }

            public string GetUserType()
            {
                if (_type == 1)
                {
                    return "Employee";
                }
                if (_type == 2)
                {
                    return "Manager";
                }
                if (_type == 3)
                {
                    return "Intern";
                }
                return null;
            }
        }
    }
}
