namespace First_API.DataAccess.Contracts_DataAccess
{
    public interface IUnitOfWork
    {

        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }

        // save operation 
        void Save();
    }
}
