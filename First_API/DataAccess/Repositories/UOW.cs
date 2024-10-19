using First_API.DataAccess.Contracts_DataAccess;

namespace First_API.DataAccess.Repositories
{
    
    public class UOW :IUnitOfWork
    {
        
        private readonly CustomDbContext _db;

        private readonly IEmployeeRepository _employeeRepository;          
        private readonly IDepartmentRepository _departmentRepository;
        public UOW(CustomDbContext db) { 
            _db = db;
            _employeeRepository= new EmployeeRepository(db);      
            _departmentRepository=new DepartmentRepository(db);


        }


        public  IEmployeeRepository EmployeeRepository { get { return _employeeRepository; } }

        public IDepartmentRepository DepartmentRepository { get { return _departmentRepository; } }    

       public void Save()
        {
            _db.SaveChanges();
        }
    }
}
