using Microsoft.AspNetCore.Mvc;
using HelloWorldCSharp.Requests;

namespace HelloWorldCSharp.Controllers
{
    public class CalculatorController : Controller
    {
        
        [HttpPost]
        [Route("api/calculator/add")]
        public IActionResult AddNumbers([FromBody] AddNumbersRequest addNumbersRequest)
        {
            return Ok(new {
                Result = addNumbersRequest.Number1 + addNumbersRequest.Number2
            });
        }
        [HttpGet]
        [Route("api/calculator/add")]
        public IActionResult AddNumbers([FromQuery(Name = "num1")] int number1=0,[FromQuery(Name ="num2")] int number2=0)
        {
            return Ok(new {
                Result = number1+number2
            });
        }
        
    }
}