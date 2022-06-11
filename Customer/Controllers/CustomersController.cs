using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Customer Service", "Hi mostafa khalaf " };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Customer Service  - {id}";
        }
    }
}
