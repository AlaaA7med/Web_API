using First_API.Application.DTO;
using First_API.DataAccess.Contracts_DataAccess;
using First_API.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_API.DataAccess.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CustomDbContext db) : base(db)
        {
        }
        public IEnumerable<Department> GetPage(int pagesize, int pagenum, out int? count, bool needtotal = false)
        {
            if (needtotal)
            {
                count = _db.Departments.Count();
            }
            else
            {
                count = null;
            }

            return _db.Departments
                .Skip((pagenum-1) * pagesize)
                .Take(pagesize);

        }
    }
}
