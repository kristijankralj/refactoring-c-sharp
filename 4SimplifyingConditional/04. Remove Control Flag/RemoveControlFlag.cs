
using System.Collections.Generic;

namespace SimplifyingConditional
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }

    public class RemoveControlFlag
    {
        public bool ValidateEmployees(List<Employee> employees)
        {
            bool allEmployeesValid = true;
            foreach (var employee in employees)
            {
                if (allEmployeesValid)
                {
                    if (!IsValid(employee))
                    {
                        allEmployeesValid = false;
                    }
                }
            }
            return allEmployeesValid;
        }

        private bool IsValid(Employee employee)
        {
            return !string.IsNullOrWhiteSpace(employee.FirstName) &&
                !string.IsNullOrWhiteSpace(employee.LastName) &&
                !string.IsNullOrWhiteSpace(employee.Role);
        }
    }
}
