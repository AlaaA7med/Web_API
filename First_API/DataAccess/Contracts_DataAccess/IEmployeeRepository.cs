using First_API.DataAccess.Entities;
using First_API.DataAccess.Repositories;

namespace First_API.DataAccess.Contracts_DataAccess
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        IEnumerable<Employee> GetPage(int pagesize, int pagenum,out int? count, bool needtotal = false);
       
    }
    
}
