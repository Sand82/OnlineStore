using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetItems() 
        {
            return new List<string>() { "Test", "Test1", "Test2", "Test3" };
        }
    }
}
