using Microsoft.AspNetCore.Mvc;
using NuPairProgramming.Host.Services;
using System.Threading.Tasks;

namespace NuPairProgramming.Host.Controllers
{
    [Route("api/hello-world")]
    public class HelloWorldController : ControllerBase
    {
        private readonly IHelloWorldService helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }

        [HttpGet]
        public ActionResult HelloWorld()
        {
            return Ok(helloWorldService.PrintHelloWorld());
        }
    }
}
