namespace GenericMemoryCache.CacheFactory
{
    public interface ICache
    {
        string CacheType();
        public T GetData<T>(string key);
        public bool SetData<T>(string key, T value, DateTimeOffset expriationTime);
        public void RemoveData<T>(string key);
    }
}
