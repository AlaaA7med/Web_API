namespace First_API.DataAccess.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; } // This is the primary key
        public string EmpName { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        public Department Departments { get; set; }
    }
}
