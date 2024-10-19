using First_API.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_API.DataAccess
{
    public class CustomDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PF54J21\\SQLEXPRESS;Initial Catalog=CompanyDB_API;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Department> departments = new List<Department>();
            List<Employee> employees = new List<Employee>();

            Random random = new Random();

            int DepNum = random.Next(5, 10);

            for (int i = 1; i <= DepNum; i++)
            {
                departments.Add(new Department
                {
                    DepartmentId = i,
                    DepatmentName = $" Department {i}",
                    Description = $"description{i}"
                });
            }

            int depCount = 1;
            int empCount = random.Next(600, 1000);
            for (int i = 1; i < empCount; i++)
            {
                depCount = random.Next(1, DepNum);
                employees.Add(new Employee
                {
                    EmployeeId = i, // This is the primary key
                    EmpName = $"emp name {i}",
                    Email = $"emp{i}@mail.com",
                    Salary = random.Next(25000, 30000),
                    DepartmentId = depCount
                });
            }

            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Department>().HasData(departments);
        }

        public DbSet<Department> Departments { get; set; }  
        public DbSet<Employee> Employees { get; set; }
        //........................................

    }
}
