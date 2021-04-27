using Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        
    }
}