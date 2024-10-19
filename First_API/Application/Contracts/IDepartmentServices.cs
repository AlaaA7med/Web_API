using First_API.Application.DTO;
using First_API.Application.DTO.EmployeeDTO;
using First_API.DataAccess.Entities;

namespace First_API.Application.Contracts
{
    public interface IDepartmentServices
    {
        public IEnumerable<Department> GetAll();
        public DepPageDto GetPage(int pagesize, int pagenum, bool needtotal = false);
        public Department GetById(int id);
        public void Insert(Department department);
        public void Update(Department department);
        public void Delete(int id);


    }
}
