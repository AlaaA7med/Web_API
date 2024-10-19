using First_API.Application.Contracts;
using First_API.DataAccess.Contracts_DataAccess;
using First_API.DataAccess.Repositories;
using First_API.DataAccess;
using First_API.DataAccess.Entities;
using First_API.Application.DTO;

namespace First_API.Application
{
    public class DepartmentServices :IDepartmentServices
    {
        private readonly IUnitOfWork _uow;
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentServices(IUnitOfWork unitOfWork, IDepartmentRepository departmentRepository )
        {
            _uow = unitOfWork;
            _departmentRepository=departmentRepository;
        }

       

        public DepPageDto GetPage(int pagesize, int pagenum, bool needtotal = false)
        {
            int? count;
            var pageData= _departmentRepository
                .GetPage(pagesize, pagenum,out count, needtotal);
            return new DepPageDto
            {
                Departmentss=pageData,
                Count=count

            };
        }
        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public  void Delete(int id)
        {
            _departmentRepository.Delete(id);
            _uow.Save();
        }


       public  Department GetById(int id)
        {
            return  _departmentRepository.FindById(id);
        }

        public  void Insert(Department department)
        {
            _departmentRepository.Insert(department);
            _uow.Save();
        }

        public void Update(Department department) {
            _departmentRepository.Update(department);
            _uow.Save();

        }
       
    }
}
