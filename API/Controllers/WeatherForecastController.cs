using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Data.Common;
namespace API.Controllers;

[ApiController]
[Route("[controller]")] //api/User
public class WeatherController : ControllerBase
{   
    public WeatherController(DataContext context)
    {

    }
   
}
