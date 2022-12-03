using Microsoft.AspNetCore.Mvc;

namespace MicroService_Sample3.Controllers;

[ApiController]
[Route("[controller]")]
public class Sample3Controller : ControllerBase
{
    public Sample3Controller()
    {
    }

    [HttpGet(Name = "hello")]
    public string Get()
    {
        return "Hello from sample 3 controller...";
    }
}

