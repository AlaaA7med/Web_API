using First_API.DataAccess.Entities;

namespace First_API.Application.DTO.EmployeeDTO
{
    public class EmployeePageDto
    {
        public IEnumerable<Employee> PageData { get; set; }
        public int? TotalCount { get; set; }
    }
}
