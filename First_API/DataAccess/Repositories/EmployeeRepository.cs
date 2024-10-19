using First_API.DataAccess.Contracts_DataAccess;
using First_API.DataAccess.Entities;

namespace First_API.DataAccess.Repositories
{
    public class EmployeeRepository :BaseRepository<Employee>,IEmployeeRepository

    {
        public EmployeeRepository(CustomDbContext db) : base(db) 
        { 
        }

        public IEnumerable<Employee> GetPage(int pagesize, int pagenum, out int? count, bool needtotal = false)
        {
            if (needtotal)
            {
                count = _db.Employees.Count();
            }
            else
            {
                count = null;
            }

            return _db.Employees
                .Skip((pagenum-1) * pagesize)
                .Take(pagesize);
        }
    
    }
}
