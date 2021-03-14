using Microsoft.AspNetCore.Mvc;

namespace TestBlazorHttp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> GetResult([FromBody] Foo foo)
        {
            return new OkObjectResult($"Hello {foo.FirstName} {foo.LastName}");
        }
    }
}
