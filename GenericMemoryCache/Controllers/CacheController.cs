

using Microsoft.AspNetCore.Mvc;


namespace GenericMemoryCache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CacheController : ControllerBase
    {

        private readonly ILogger<CacheController> _logger;
        private readonly CacheFactory.CacheFactory _cacheFactory;


        public CacheController(ILogger<CacheController> logger, CacheFactory.CacheFactory cacheFactory)
        {
            _logger = logger;
            _cacheFactory = cacheFactory;
        }

        [HttpGet(Name = "GetCachedData")]
        public string Get( )
        {
            var result = _cacheFactory.getCache("memory");
            Console.WriteLine(result.CacheType());
            return "";
        }
    }
}