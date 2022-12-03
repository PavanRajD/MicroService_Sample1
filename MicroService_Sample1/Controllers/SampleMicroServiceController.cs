using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Mvc;

namespace MicroService_Sample1.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleMicroServiceController : ControllerBase
{
    public SampleMicroServiceController()
    {
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<string> Get()
    {
        var resultMicroService1 = "";
        var resultMicroService2 = "";

        HttpClient client = new HttpClient();

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        // List data response.
        HttpResponseMessage response = client.GetAsync("https://localhost:7075/Sample2").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

        if (response.IsSuccessStatusCode)
        {
            // Parse the response body.
            resultMicroService1 = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
        }

        response = client.GetAsync("https://localhost:7170/Sample3").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

        if (response.IsSuccessStatusCode)
        {
            // Parse the response body.
            resultMicroService2 = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
        }

        return new List<string> { resultMicroService1, resultMicroService2 };
    }
}

