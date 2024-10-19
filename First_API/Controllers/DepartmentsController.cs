using First_API.Application;
using First_API.Application.Contracts;
using First_API.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentServices _departmentService;
        public DepartmentsController(IDepartmentServices departmentService)
        {
            _departmentService=departmentService;
        }
        [HttpGet]
        public ActionResult GetPage(int pagesize, int pagenum, bool needtotal) {
            return Ok(_departmentService.GetPage(pagesize, pagenum, needtotal));
        
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_departmentService.GetAll());
        }

        [HttpPost]
        public ActionResult Insert(Department dep)
        {
            _departmentService.Insert(dep);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(Department dep)
        {
            _departmentService.Update(dep);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _departmentService.Delete(id);
            return Ok();

        }

    }
}
