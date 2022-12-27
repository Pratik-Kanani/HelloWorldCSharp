using Microsoft.AspNetCore.Mvc;
using HelloWorldCSharp.Requests;

namespace HelloWorldCSharp.Controllers
{
    public class TimeOutController : Controller
    {
        [HttpGet]
        [Route("api/responsetimer")]
        public IActionResult GiveResponseAfterTime([FromQuery] int time=10)
        {
            Thread.Sleep(time);
            return Ok(new {
                Message = $"Api slept for {time} ms."
            });
        }
    }
}