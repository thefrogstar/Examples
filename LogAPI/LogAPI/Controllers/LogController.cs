using LogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogAPI.Controllers
{
    [Route("/LogAPI")]
    [ApiController]
    public class LogController : ControllerBase
    {      
        [HttpPost]
        public IActionResult Post(LogMessage message)
        {
            DAL backend = new DAL();
            backend.LogMessage(message);
            return new OkResult();
        }
    }
}
