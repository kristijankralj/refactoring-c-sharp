namespace MovingFeatures
{
    public class RemoveMiddleMan
    {
        public RemoveMiddleMan()
        {
            var employee = new Employee();

            var getProjectManager = employee.Manager;
        }

        class Employee
        {
            private Project AssignedProject { get; set; }

            public ProjectManager Manager { get { return AssignedProject.ProjectManager; } }
        }

        class Project
        {
            public ProjectManager ProjectManager { get; set; }
        }

        class ProjectManager
        {

        }
    }
}
