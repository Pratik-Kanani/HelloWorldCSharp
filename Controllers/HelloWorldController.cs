using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions;

namespace HelloWorldCSharp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static IConfiguration ?_configuration ;
        public HelloWorldController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("api/message")]
        public IActionResult GetMessage()
        {
            return Ok(new {
                Message = "Hey listen ... GET LOST. I mean HELLO WORLD!"
            });
        }
    }
}