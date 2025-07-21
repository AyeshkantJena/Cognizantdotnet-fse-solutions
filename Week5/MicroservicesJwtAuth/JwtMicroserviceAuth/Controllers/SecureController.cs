using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtMicroserviceAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("data")]
        [Authorize]
        public IActionResult GetSecureData()
        {
            return Ok("🔒 You are authenticated.");
        }

        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminData()
        {
            return Ok("👑 You are an admin.");
        }
    }
}
