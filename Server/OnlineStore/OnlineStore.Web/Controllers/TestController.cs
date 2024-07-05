using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string>() { "test1", "test2", "test3"};
        }
    }
}
