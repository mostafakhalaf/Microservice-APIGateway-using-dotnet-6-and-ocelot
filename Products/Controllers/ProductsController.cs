using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Products Service", "Hi mostafa kalaf" };
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Products Service  - {id}";
        }
    }
}
