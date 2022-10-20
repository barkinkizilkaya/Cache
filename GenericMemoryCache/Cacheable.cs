using GenericMemoryCache.Helper;

namespace GenericMemoryCache
{
    [AttributeUsage(AttributeTargets.All)]
    public class Cacheable : Attribute {

        private string _methodName;
        private CacheTypes _cacheType;

        public Cacheable(string MethodName, CacheTypes CacheType)
        {
            _methodName = MethodName;
            _cacheType = CacheType;       
        }

        public string MethodName { get => _methodName; }
        public CacheTypes CacheType { get => _cacheType;  }
    }  
  
}
