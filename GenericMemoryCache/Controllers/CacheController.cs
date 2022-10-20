

using GenericMemoryCache.Helper;
using Microsoft.AspNetCore.Mvc;


namespace GenericMemoryCache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CacheController : ControllerBase
    {
        public CacheController()
        {
        }
       
        [HttpGet("{AccountId}")]
        [Cacheable("GetCachedData",CacheTypes.InMemory)]
        public string Get(int AccountId)
        {
           
            Console.WriteLine("test");
            return "";
        }
    }
}