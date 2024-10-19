using First_API.Application.DTO.EmployeeDTO;
using First_API.DataAccess.Entities;

namespace First_API.Application.Contracts
{
    public interface IEmployeeServices
    {

       public  IEnumerable<Employee> GetAll();


       public EmployeePageDto GetPage(int pagesize, int pagenum, bool needtotal = false);

       public Employee GetById(int id);
       public  void Insert (Employee employee);    
       public void Update (Employee employee );    
       public void Delete (int id);


    }
}
