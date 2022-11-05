using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetEmployees()
        {
            return Ok();
        }
    }
}
