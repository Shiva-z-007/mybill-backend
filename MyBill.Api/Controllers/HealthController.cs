using Microsoft.AspNetCore.Mvc;

namespace MyBill.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>Ok(new {status = "MyBill API is Running",timeStamp = DateTime.UtcNow});
    }
}
