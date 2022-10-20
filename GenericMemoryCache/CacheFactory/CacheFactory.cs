using GenericMemoryCache.Helper;
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

       
        public  ICache getCache(CacheTypes Type)
        {
        
            if (Type == CacheTypes.InMemory)
            {
                return (ICache)_serviceProvider.GetService(typeof(Memory));
            
            }               
            else
                return (ICache)_serviceProvider.GetService(typeof(Redis));

          
        }

    }
}
