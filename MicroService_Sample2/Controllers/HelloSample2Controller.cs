using Microsoft.AspNetCore.Mvc;

namespace MicroService_Sample2.Controllers;

[ApiController]
[Route("[controller]")]
public class Sample2Controller : ControllerBase
{
    public Sample2Controller()
    {
    }

    public string Get()
    {
        return "Hello from sample 2 web application...";
    }
}

