using Microsoft.Extensions.Caching.Memory;

namespace GenericMemoryCache.CacheFactory
{
   public class CacheFactory
    {
      
        private IServiceProvider _serviceProvider;

        public CacheFactory(ICache cache, IServiceProvider serviceProvider)
        {
         
            _serviceProvider = serviceProvider;
        }

        [CacheAttribute("getanimal", "memory")]
        public  ICache getCache(String Type)
        {
        
            if (Type.ToLower().Equals("memory"))
            {
                return (ICache)_serviceProvider.GetService(typeof(Memory));
            
             }               
            else
                return (ICache)_serviceProvider.GetService(typeof(Redis));

          
        }

    }
}
