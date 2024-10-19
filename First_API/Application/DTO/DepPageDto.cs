using First_API.DataAccess.Entities;

namespace First_API.Application.DTO
{
    public class DepPageDto
    {
        public  IEnumerable<Department> Departmentss { get; set; }
        public int? Count { get; set; }    
    }

    
}
