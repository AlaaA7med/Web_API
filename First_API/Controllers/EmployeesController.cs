using First_API.Application;
using First_API.Application.Contracts;
using First_API.Application.DTO.EmployeeDTO;
using First_API.Application.QueryOptions;
using First_API.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;
        public EmployeesController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices; 
        }
        [HttpGet("{PageNum}")]
        public ActionResult<EmployeePageDto> GetPage(int pagesize, int pagenum, bool needtotal) {

            return Ok(_employeeServices.GetPage(pagesize, pagenum, needtotal));

        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_employeeServices.GetAll());
        }

        [HttpPost]
        public ActionResult Insert(Employee Emp) {
            _employeeServices.Insert(Emp);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(Employee employee) {
            _employeeServices.Update(employee);
            return Ok();    
        }

        [HttpDelete]
        public ActionResult Delete(int id) { 
            _employeeServices.Delete(id);   
            return Ok();
        
        }

    }
}
