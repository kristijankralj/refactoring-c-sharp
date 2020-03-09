using System;

namespace OrganizingData
{
    public class ReplaceTypeCodeWithStateStrategy
    {
        public ReplaceTypeCodeWithStateStrategy()
        {
            var lowLevelManager = new Manager(Manager.LOW_LEVEL, 30000);
            decimal salary = lowLevelManager.GetMonthlySalary(0);
            lowLevelManager.SetLevel(Manager.MIDDLE_LEVEL);
        }

        class Manager
        {
            public const int LOW_LEVEL = 0;
            public const int MIDDLE_LEVEL = 1;
            public const int TOP_LEVEL = 2;

            private int _managerLevel;
            private decimal _baseSalary;

            public Manager(int level, decimal baseSalary)
            {
                _managerLevel = level;
                _baseSalary = baseSalary;
            }

            //The level can be changed in this case
            public void SetLevel(int newLevel)
            {
                _managerLevel = newLevel;
            }

            public decimal GetMonthlySalary(int numberOfPeopleInDepartment)
            {
                switch (_managerLevel)
                {
                    case LOW_LEVEL:
                        return _baseSalary;
                    case MIDDLE_LEVEL:
                        return _baseSalary * 1.25M;
                    case TOP_LEVEL:
                        return (_baseSalary * 1.25M) + (decimal)(numberOfPeopleInDepartment * 0.05);
                    default:
                        return 0;
                }
            }
        }
    }
}
