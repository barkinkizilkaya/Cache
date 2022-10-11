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
            _memoryCache.TryGetValue<T>(key, out var value);
            return value;
        }

        public void RemoveData(string key)
        {
            _memoryCache.Remove(key);
        }

        public void SetData<T>(string key, T value, DateTimeOffset expriationTime)
        {
            _memoryCache.Set(key, value, expriationTime);
        }
    }
}
