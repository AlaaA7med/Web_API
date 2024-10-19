using First_API.DataAccess.Entities;

namespace First_API.DataAccess.Contracts_DataAccess
{
    public interface IDepartmentRepository:IBaseRepository<Department>
    {
        IEnumerable<Department> GetPage(int pagesize, int pagenum, out int? count, bool needtotal = false);
       


    }
}