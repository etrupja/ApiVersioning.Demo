using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Demo.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IActionResult GetV1() => Ok("Version 1.0 - Items");

        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2() => Ok("Version 2.0 - Items");
    }
}