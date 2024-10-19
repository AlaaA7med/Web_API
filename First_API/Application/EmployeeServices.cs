using First_API.Application.Contracts;
using First_API.Application.DTO.EmployeeDTO;
using First_API.Application.QueryOptions;
using First_API.DataAccess;
using First_API.DataAccess.Contracts_DataAccess;
using First_API.DataAccess.Entities;
using First_API.DataAccess.Repositories;

namespace First_API.Application
{
    public class EmployeeServices :IEmployeeServices

    {
        //1
        private readonly IUnitOfWork _uow;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeServices(IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
        {

            _uow =  unitOfWork; //2
            _employeeRepository=employeeRepository;

        }

        public EmployeePageDto GetPage(int pagesize, int pagenum, bool needtotal=false) {
            var pageData = _employeeRepository.GetAll()   //3
                .Skip((pagenum-1)*pagesize)
                .Take(pagesize);
            return new EmployeePageDto
            {
                PageData = pageData,
                TotalCount=needtotal ? _employeeRepository.GetAll().Count():null

            };
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.FindById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();    
        }

        public void Insert(Employee employee)
        {
            _employeeRepository.Insert(employee);
            _uow.Save();
        }

        public void Update(Employee employee)
        {
            _employeeRepository.Update(employee);
            _uow.Save();
        }

        public void Delete(int id)
        {
            _employeeRepository.Delete(id); 
            _uow.Save();
        }


        //private IEmployeeRepository _employeeRepository=>_uow.EmployeeRepository; //4
    }
}
