namespace MovingFeatures
{
    public class HideDelegate
    {
        public HideDelegate()
        {
            var employee = new Employee();

            var getProjectManager = employee.AssignedProject.Manager;
        }

        class Employee
        {
            public Project AssignedProject { get; set; }
        }

        class Project
        {
            public ProjectManager Manager { get; set; }
        }

        class ProjectManager
        {

        }
    }
}
