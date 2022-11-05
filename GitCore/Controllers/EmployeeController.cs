using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddEmployee()
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            return Ok();
        }
    }
}
