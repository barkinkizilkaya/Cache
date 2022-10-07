using Microsoft.Extensions.Caching.Memory;

namespace GenericMemoryCache.CacheFactory
{
    public class Memory : ICache
    {
        private readonly IMemoryCache _memoryCache;
        public Memory(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public string CacheType()
        {
            return "Memory";
        }

        public T GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expriationTime)
        {
            throw new NotImplementedException();
        }
    }
}
