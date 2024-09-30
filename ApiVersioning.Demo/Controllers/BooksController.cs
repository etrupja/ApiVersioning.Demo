using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Demo.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // Action for version 1.0
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IActionResult GetV1()
        {
            return Ok("Version 1.0 - Books");
        }

        // Action for version 2.0
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2()
        {
            return Ok("Version 2.0 - Books");
        }
    }
}
