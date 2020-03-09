using System;
namespace SimplifyingConditional
{
    public class ReplaceConditionalWithPolymorphism
    {
        class Manager
        {
            private ManagerLevel _managerLevel;
            private decimal _baseSalary;

            public Manager(int level, decimal baseSalary)
            {
                SetLevel(level);
                _baseSalary = baseSalary;
            }

            public void SetLevel(int newLevel)
            {
                _managerLevel = ManagerLevel.NewLevel(newLevel);
            }

            public decimal GetMonthlySalary(int numberOfPeopleInDepartment)
            {
                //Replace this conditional
                switch (GetManagerLevel())
                {
                    case ManagerLevel.LOW_LEVEL:
                        return _baseSalary;
                    case ManagerLevel.MIDDLE_LEVEL:
                        return _baseSalary * 1.25M;
                    case ManagerLevel.TOP_LEVEL:
                        return (_baseSalary * 1.25M) + (decimal)(numberOfPeopleInDepartment * 0.05);
                    default:
                        return 0;
                }
            }

            private int GetManagerLevel()
            {
                return _managerLevel.GetLevel();
            }
        }

        abstract class ManagerLevel
        {
            public const int LOW_LEVEL = 0;
            public const int MIDDLE_LEVEL = 1;
            public const int TOP_LEVEL = 2;

            internal abstract int GetLevel();

            public static ManagerLevel NewLevel(int newLevel)
            {
                switch (newLevel)
                {
                    case LOW_LEVEL:
                        return new LowLevel();
                    case MIDDLE_LEVEL:
                        return new MiddleLevel();
                    case TOP_LEVEL:
                        return new HighLevel();
                    default:
                        throw new ArgumentException("Invalid level.");
                }
            }
        }

        class LowLevel : ManagerLevel
        {
            internal override int GetLevel()
            {
                return LOW_LEVEL;
            }
        }

        class MiddleLevel : ManagerLevel
        {
            internal override int GetLevel()
            {
                return MIDDLE_LEVEL;
            }
        }

        class HighLevel : ManagerLevel
        {
            internal override int GetLevel()
            {
                return TOP_LEVEL;
            }
        }
    }
}
