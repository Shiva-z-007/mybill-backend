using Microsoft.AspNetCore.Mvc;
using MyBill.Api.Data;
using MyBill.Api.Models;

namespace MyBill.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _db;
        public TestController(AppDbContext db) => _db = db;

        [HttpPost("create-user")]
        public IActionResult CreateUser([FromBody] User u)
        {
            _db.Users.Add(u);
            _db.SaveChanges();
            return Ok(new { success = true , id = u.Id});
        }

        [HttpGet("Users")]
        public IActionResult GetUsers() => Ok(_db.Users.ToList());
        

    }
}
